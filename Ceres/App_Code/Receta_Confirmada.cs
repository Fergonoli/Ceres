using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Receta_Confirmada
/// </summary>
public class Receta_Confirmada : Receta
{
    protected System.DateTime Fecha;
    //El formato del date  " & Format(#5/31/1993#, "dddd, d MMM yyyy"

	public Receta_Confirmada()
	{
        Nombre = null;
        Categoria = null;
        Nombre_Autor = null;
        Ruta_Formulario = null;

        //Jodido problema con las dixosas fechas necesita un arreglo o cambio XDDDDDDDDD
        //Fecha  = #0/00/0000 0:00 PM#;

	}
    	
    public Receta_Confirmada(String Nom, String Categ, String Nombre_Aut, String Ruta_Form, DateTime Fech)
	{
        Nombre = Nom;
        Categoria = Categ;
        Nombre_Autor = Nombre_Aut;
        Ruta_Formulario = Ruta_Form;

        Fecha  = Fech;
	}


}