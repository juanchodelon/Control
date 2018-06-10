using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class _Default : Page
{
    List<Productos> producto = new List<Productos>();
    String nick = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        /******lee el archivo de texto y lo guarda en una lista******/
        String filename = Server.MapPath("/App_Data/Productos.txt");
        FileStream stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(stream);

        while (reader.Peek() > -1)
        {
            Productos ptemp = new Productos();
            ptemp.Id = Convert.ToInt32(reader.ReadLine());
            ptemp.Nombre = reader.ReadLine();
            ptemp.Precio = Convert.ToInt32(reader.ReadLine());
            ptemp.Existencias = Convert.ToInt32(reader.ReadLine());
            ptemp.Categoria = reader.ReadLine();
            ptemp.Descripcion = reader.ReadLine();
            ptemp.Ventas = Convert.ToInt32(reader.ReadLine());
            producto.Add(ptemp);
        }
        reader.Close();
        pgrid.DataSource = producto;
        pgrid.DataBind();
    }
}