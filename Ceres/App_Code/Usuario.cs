using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Usuario
/// </summary>
public class Usuario
{

    public int ID;
    public String Nombre {get;set;}
    public String Apellido1 {get;set;}
    public String Apellido2{get;set;}
    public String Alias{get;set;}
    public String Contrasena;


	public Usuario()
	{
        Nombre = null;
        Apellido1 = null;
        Apellido2 = null;
        Alias = null;
        Contrasena = null;
	}

    public Usuario(String Nom, String Ape1, String Ape2, String Ali,String contrasena)
    {
        Nombre = Nom;
        Apellido1 = Ape1;
        Apellido2 = Ape2;
        Alias = Ali;
        Contrasena = contrasena;
    }

    public void SubirReceta(String nomb, String categ, String Ruta_Form)
    {     
        //Receta RecetaNueva = new Receta(nomb, categ, this.Alias, Ruta_Form);
        Almacenaje almacenaje = new Almacenaje();
        almacenaje.AlmacenarReceta(nomb, categ, this.ID, Ruta_Form, 3);
    }

    public void ModificarReceta(Receta Recet, String nomb, String categ, String Ruta_Form)
    {
        Recet.ModificarReceta(nomb, categ, this.Nombre, Ruta_Form);
    }

    public void AltaUsuario(String alias, String nombre, String apellido1, String apellido2, String Contrasena)
    {
        Almacenaje almacenaje = new Almacenaje();
        almacenaje.InsertaUsuario(alias, nombre, apellido1 + apellido2, Contrasena);
        
    }
}