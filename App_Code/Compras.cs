using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Compras
/// </summary>
public class Compras
{
    public Compras()
    {
    }
    int codigoprod;
    int nit;
    int cantidad;
    int pago;
    String cajero;
    DateTime fecha;

    public int Codigoprod
    {
        get
        {
            return codigoprod;
        }

        set
        {
            codigoprod = value;
        }
    }

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

    public int Cantidad
    {
        get
        {
            return cantidad;
        }

        set
        {
            cantidad = value;
        }
    }

    public int Pago
    {
        get
        {
            return pago;
        }

        set
        {
            pago = value;
        }
    }

    public string Cajero
    {
        get
        {
            return cajero;
        }

        set
        {
            cajero = value;
        }
    }

    public DateTime Fecha
    {
        get
        {
            return fecha;
        }

        set
        {
            fecha = value;
        }
    }
}