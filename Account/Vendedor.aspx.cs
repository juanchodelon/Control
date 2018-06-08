using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class Account_Vendedor : System.Web.UI.Page
{
    List<Productos> mios = new List<Productos>();
    List<Productos> producto = new List<Productos>();
    List<Cliente> cliente = new List<Cliente>();

    Random rnd = new Random();
    int idprop = 0;
    string nick = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        /******lee el archivo de texto y lo guarda en una lista******/
        String filename = Server.MapPath("../App_Data/Productos.txt");
        FileStream stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(stream);

        int id = Convert.ToInt32(Session["id"]);
        nick = Convert.ToString(Session["nick"]);
        name.Text = Convert.ToString(nick);
        correo.Text = Convert.ToString(id);

        while (reader.Peek() > -1)
        {
            Productos ptemp = new Productos();
            ptemp.Id = Convert.ToInt32(reader.ReadLine());
            ptemp.Nombre = reader.ReadLine();
            ptemp.Precio = Convert.ToInt32(reader.ReadLine());
            ptemp.Existencias = Convert.ToInt32(reader.ReadLine());
            ptemp.Categoria = reader.ReadLine();
            ptemp.Descripcion = reader.ReadLine();
            ptemp.Propietario = reader.ReadLine();
            ptemp.Ventas = Convert.ToInt32(reader.ReadLine());
            producto.Add(ptemp);
        }
        reader.Close();

        /***muestra solamente los productos publicados por el usuario***/
        /***no por los demas usuarios***/
        for (int i = 0; i < producto.Count; i++)
        {
            if (name.Text == producto[i].Propietario)
            {
                Productos mio = new Productos();
                mio.Id = producto[i].Id;
                mio.Nombre = producto[i].Nombre;
                mio.Categoria = producto[i].Categoria;
                mio.Descripcion = producto[i].Descripcion;
                mio.Precio = producto[i].Precio;
                mio.Existencias = producto[i].Existencias;
                mio.Ventas = producto[i].Ventas;
                mio.Propietario = "yo";
                mios.Add(mio);
            }
        }
        pgrid.DataSource = mios;
        pgrid.DataBind();

    }

    protected void Crear_Click(object sender, EventArgs e)
    {
        /******escribe el archivo de texto******/
        String filename = Server.MapPath("../App_Data/Productos.txt");
        FileStream stream = new FileStream(filename, FileMode.Append, FileAccess.Write);
        StreamWriter writer = new StreamWriter(stream);

        int id = rnd.Next(100,999);

        writer.WriteLine(id);
        writer.WriteLine(Pname.Text);
        writer.WriteLine(precio.Text);
        writer.WriteLine(existencias.Text);
        writer.WriteLine(category.Text);
        writer.WriteLine(descripcion.Text);
        writer.WriteLine(nick);
        writer.Close();

    }

    protected void modificar_Click(object sender, EventArgs e)
    {
        /******escribe el archivo de texto******/
        String filename = Server.MapPath("../App_Data/Productos.txt");
        FileStream stream = new FileStream(filename, FileMode.Truncate, FileAccess.Write);
        StreamWriter writer = new StreamWriter(stream);

        int codigo = Convert.ToInt32(Codigo.Text);

        for (int i = 0; i < producto.Count; i++)
        {
            if (codigo == producto[i].Id)
            {
                producto[i].Nombre = nuevonombre.Text;
                producto[i].Descripcion = nuevadescrip.Text;
                producto[i].Existencias = Convert.ToInt32(nuevoexist.Text);
                producto[i].Precio = Convert.ToInt32(nuevoprecio.Text);
            }
        }

        for (int a = 0; a < producto.Count; a++)
        {
            writer.WriteLine(producto[a].Id);
            writer.WriteLine(producto[a].Nombre);
            writer.WriteLine(producto[a].Precio);
            writer.WriteLine(producto[a].Existencias);
            writer.WriteLine(producto[a].Categoria);
            writer.WriteLine(producto[a].Descripcion);
            writer.WriteLine(producto[a].Propietario);
        }
        writer.Close();
        /****refrescar****/
        Response.Redirect("~/Account/Vendedor");
    }

    protected void btnverificar_Click(object sender, EventArgs e)
    {
        /******lee el archivo de texto de los clientes*****/
        String cname = Server.MapPath("../App_Data/Clientes.txt");
        FileStream cstream = new FileStream(cname, FileMode.Open, FileAccess.Read);
        StreamReader creader = new StreamReader(cstream);

        while (creader.Peek() > -1)
        {
            Cliente ctemp = new Cliente();
            ctemp.Nit = Convert.ToInt32(creader.ReadLine());
            ctemp.Nombre = creader.ReadLine();
            ctemp.Numerotelefono = Convert.ToInt32(creader.ReadLine());
            ctemp.Compras = Convert.ToInt32(creader.ReadLine());
            cliente.Add(ctemp);
        }
        creader.Close();

        int nit = Convert.ToInt32(txtnit.Text);
        bool find = false;
        for (int i = 0; i < cliente.Count; i++)
        {
            if (nit == cliente[i].Nit)
            {
                txnit.Text = Convert.ToString(cliente[i].Nit);
                txtnombre.Text = cliente[i].Nombre;
                txttelefono.Text = Convert.ToString(cliente[i].Numerotelefono);
                txtsucces.Text = "cliente encontrado";
                find = true;
            }
            else
                find = false;
        }
        if (find == false)
        {
            txterror.Text = "el cliente no existe";
        }
    }

    protected void comprar_Click(object sender, EventArgs e)
    {
        /******escribe el archivo de texto para un cliente*****
        String filename = Server.MapPath("../App_Data/Productos.txt");
        FileStream stream = new FileStream(filename, FileMode.Append, FileAccess.Write);
        StreamWriter writer = new StreamWriter(stream);

        writer.WriteLine(cnombre.Text);
        writer.WriteLine(cnit.Text);
        writer.WriteLine(ctelefono.Text);
        writer.Close();*/
    }

    protected void BtnaddCliente_Click(object sender, EventArgs e)
    {
        /******escribe el archivo de texto para un cliente******/
        String cname = Server.MapPath("../App_Data/Clientes.txt");
        FileStream cstream = new FileStream(cname, FileMode.Append, FileAccess.Write);
        StreamWriter cwriter = new StreamWriter(cstream);

        cwriter.WriteLine(cnombre.Text);
        cwriter.WriteLine(cnit.Text);
        cwriter.WriteLine(ctelefono.Text);
        cwriter.WriteLine("0");
        cwriter.Close();
    }
}