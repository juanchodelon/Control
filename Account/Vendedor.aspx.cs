﻿using System;
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
        int id = Convert.ToInt32(Session["id"]);
        nick = Convert.ToString(Session["nick"]);
        name.Text = Convert.ToString(nick);
        correo.Text = Convert.ToString(id);

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

        /******lee el archivo de texto y lo guarda en una lista******/
        String filename1 = Server.MapPath("../App_Data/Productos.txt");
        FileStream stream1 = new FileStream(filename1, FileMode.Open, FileAccess.Read);
        StreamReader reader1 = new StreamReader(stream1);

        while (reader1.Peek() > -1)
        {
            Productos ptemp = new Productos();
            ptemp.Id = Convert.ToInt32(reader1.ReadLine());
            ptemp.Nombre = reader1.ReadLine();
            ptemp.Precio = Convert.ToInt32(reader1.ReadLine());
            ptemp.Existencias = Convert.ToInt32(reader1.ReadLine());
            ptemp.Categoria = reader1.ReadLine();
            ptemp.Descripcion = reader1.ReadLine();
            ptemp.Propietario = reader1.ReadLine();
            ptemp.Ventas = Convert.ToInt32(reader1.ReadLine());
            producto.Add(ptemp);
        }
        reader1.Close();

        /***muestra solamente los productos publicados por el usuario***/
        /***no por los demas usuarios***/
        for (int i = 0; i < producto.Count; i++)
        {
            if (name.Text == producto[i].Propietario)
            {
                Productos mio = new Productos();
                mio.Id = producto[i].Id;
                mio.Nombre = producto[i].Nombre;
                mio.Precio = producto[i].Precio;
                mio.Existencias = producto[i].Existencias;
                mio.Categoria = producto[i].Categoria;
                mio.Descripcion = producto[i].Descripcion;
                mio.Propietario = "yo";
                mio.Ventas = producto[i].Ventas;
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
        writer.WriteLine("0");
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
            writer.WriteLine(producto[a].Ventas);
        }
        writer.Close();
        /****refrescar****/
        Response.Redirect("~/Account/Vendedor");
    }

    protected void btnverificar_Click(object sender, EventArgs e)
    {
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

    protected void comprar_Click1(object sender, EventArgs e)
    {
        //busca el producto
        int codigo = Convert.ToInt32(codigoprod.Text);
        int cant = Convert.ToInt32(cantidad.Text);
        int pago = Convert.ToInt32(txtpago.Text);
        int nitcliente = Convert.ToInt32(txtnit.Text);
        int total = 0, vuelto;

        for (int i = 0; i < producto.Count; i++)
        {
            if (codigo == producto[i].Id)
            {
                total = cant * producto[i].Precio;
                txtsucces.Text = Convert.ToString("el total es de: " + total + " quetzales");
            }
        }
        vuelto = pago - total;
        if (vuelto < 0 )
        {
            succesvuelto.Text = Convert.ToString("hace falta: " + vuelto * -1 + " quetzales");
        }else
        {
            succesvuelto.Text = Convert.ToString("cambio: " + vuelto + " quetzales");
            /******escribe el archivo de texto para un cliente******/
            String cfilename = Server.MapPath("../App_Data/Compras.txt");
            FileStream cstream = new FileStream(cfilename, FileMode.Append, FileAccess.Write);
            StreamWriter cwriter = new StreamWriter(cstream);

            cwriter.WriteLine(codigoprod.Text);
            cwriter.WriteLine(txtnit.Text);
            cwriter.WriteLine(cantidad.Text);
            cwriter.WriteLine(total);
            cwriter.WriteLine(cajeros.Text);
            cwriter.Close();

            //cambia el numero de compras
            for (int i = 0; i < cliente.Count; i++)
            {
                if (nitcliente == cliente[i].Nit)
                {
                    cliente[i].Compras += 1;
                }
            }

            /********reescribe para aumentar las compras********/
            String mfilename = Server.MapPath("../App_Data/Clientes.txt");
            FileStream mstream = new FileStream(mfilename, FileMode.Truncate, FileAccess.Write);
            StreamWriter mwriter = new StreamWriter(mstream);

            for (int a = 0; a < cliente.Count; a++)
            {
                mwriter.WriteLine(cliente[a].Nit);
                mwriter.WriteLine(cliente[a].Nombre);
                mwriter.WriteLine(cliente[a].Numerotelefono);
                mwriter.WriteLine(cliente[a].Compras);
            }
            mwriter.Close();

            String filename = Server.MapPath("../App_Data/Productos.txt");
            FileStream stream = new FileStream(filename, FileMode.Truncate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            for (int i = 0; i < producto.Count; i++)
            {
                if (codigo == producto[i].Id)
                {
                    producto[i].Existencias -= 1;
                    producto[i].Existencias += 1;
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
                writer.WriteLine(producto[a].Ventas);
            }
            writer.Close();
            
        /****refrescar****/
        Response.Redirect("~/Account/Vendedor");
        }
    }
}