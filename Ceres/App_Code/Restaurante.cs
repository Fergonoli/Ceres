using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Restaurante
/// </summary>
public class Restaurante : Usuario
{
    protected String Direccion{ get;set;}
    protected float Precio{ get;set;}

    public Restaurante():base()
    {        
        Direccion = null;
        Precio = 0;
    }

    public Restaurante(String Nom, String Ape1, String Ape2, String Ali, String Direc, float prec)
    {
        Nombre = Nom;
        Apellido1 = Ape1;
        Apellido2 = Ape2;
        Alias = Ali;
        Direccion = Direc;
        Precio = prec;
    }

}