using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class Account_Login : System.Web.UI.Page
{
    List<Usuario> user = new List<Usuario>();
    protected void Page_Load(object sender, EventArgs e)
    {
        /*****lee los datos del archivo de texto y los almacena en una lista*****/
        String filename = Server.MapPath("../App_Data/Users.txt");
        FileStream stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(stream);

        while (reader.Peek() > -1)
        {
            Usuario utemp = new Usuario();
            utemp.Nombre = reader.ReadLine();
            utemp.Password = reader.ReadLine();
            utemp.Id = Convert.ToInt32(reader.ReadLine());
            user.Add(utemp);
        }
        reader.Close();

    }

    protected void Login_Click(object sender, EventArgs e)
    {
        bool p = false, n = false;

        if (Password.Text == "admin" && UserName.Text == "Admin")
        {
            Session["loged"] = 2;
            Response.Redirect("~/Account/Administrador");
        }
        else
        {
            for (int i = 0; i < user.Count; i++)
            {
                if (Password.Text == user[i].Password && UserName.Text == user[i].Nombre)
                {
                    n = true;
                    p = true;
                    Session["id"] = user[i].Id;
                    Session["nick"] = user[i].Nombre;
                    Session["loged"] = 1;
                    Response.Redirect("~/Account/Vendedor");
                }
                else
                    error.Text = "nombre de usuario o clave incorrectas!";
            }
        }
    }
}