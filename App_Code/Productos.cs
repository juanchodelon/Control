using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Productos
/// </summary>
public class Productos
{
    public Productos()
    {
    }

    int id;
    String nombre;
    int precio;
    int existencias;
    String categoria;
    String descripcion;
    String propietario;

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

    public int Precio
    {
        get
        {
            return precio;
        }

        set
        {
            precio = value;
        }
    }

    public int Existencias
    {
        get
        {
            return existencias;
        }

        set
        {
            existencias = value;
        }
    }

    public string Categoria
    {
        get
        {
            return categoria;
        }

        set
        {
            categoria = value;
        }
    }

    public string Descripcion
    {
        get
        {
            return descripcion;
        }

        set
        {
            descripcion = value;
        }
    }

    public string Propietario
    {
        get
        {
            return propietario;
        }

        set
        {
            propietario = value;
        }
    }
}