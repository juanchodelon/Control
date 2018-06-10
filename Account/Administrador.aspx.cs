using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class Account_Administrador : System.Web.UI.Page
{
    Random rnd = new Random();
    string nick = "";
    List<Productos> producto = new List<Productos>();
    List<Cliente> cliente = new List<Cliente>();
    protected void Page_Load(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(Session["id"]);
        nick = Convert.ToString(Session["nick"]);


    }

    protected void agregar_Click(object sender, EventArgs e)
    {
        /******escribe el archivo de texto de empleados******/
        String filename = Server.MapPath("../App_Data/Users.txt");
        FileStream stream = new FileStream(filename, FileMode.Append, FileAccess.Write);
        StreamWriter writer = new StreamWriter(stream);

        int id = rnd.Next(100, 999);

        writer.WriteLine(UserName.Text);
        writer.WriteLine(Password.Text);
        writer.WriteLine(id);
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
            writer.WriteLine(producto[a].Ventas);
        }
        writer.Close();
        /****refrescar***/
        Response.Redirect("~/Account/Vendedor");
    }
    protected void Crear_Click(object sender, EventArgs e)
    {
        /******escribe el archivo de texto*****/
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
        writer.WriteLine("0");
        writer.Close();

    }
 }