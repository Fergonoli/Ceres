using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Receta_A_Modificar
/// </summary>
public class Receta_A_Modificar : Receta
{

    public String CampoError;
    public Estado estado;

	public Receta_A_Modificar()
	{
        Nombre = null;
        Categoria = null;
        Nombre_Autor = null;
        Ruta_Formulario = null;

        CampoError = null;
	}

    public Receta_A_Modificar(String Nom, String Categ, String Nombre_Aut, String Ruta_Form, String CampoEr)
    {
        Nombre = Nom;
        Categoria = Categ;
        Nombre_Autor = Nombre_Aut;
        Ruta_Formulario = Ruta_Form;
        CampoError = CampoEr;
    }
}