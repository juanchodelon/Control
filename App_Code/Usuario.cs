using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Usuario
/// </summary>
public class Usuario
{
    public Usuario()
    {
    }
    String nombre;
    String password;
    int id;
    public string Nombre
    {
        get
        {
            return nombre;
        }

        set
        {
            nombre = value;
        }
    }
    public string Password
    {
        get
        {
            return password;
        }

        set
        {
            password = value;
        }
    }
    public int Id
    {
        get
        {
            return id;
        }

        set
        {
            id = value;
        }
    }
}