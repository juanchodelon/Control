using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Cliente
/// </summary>
public class Cliente
{
    public Cliente()
    {
    }

    int nit;
    String nombre;
    int numerotelefono;
    int compras;

    public int Nit
    {
        get
        {
            return nit;
        }

        set
        {
            nit = value;
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

    public int Numerotelefono
    {
        get
        {
            return numerotelefono;
        }

        set
        {
            numerotelefono = value;
        }
    }

    public int Compras
    {
        get
        {
            return compras;
        }

        set
        {
            compras = value;
        }
    }
}