using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Receta
/// </summary>
public class Receta
{

    public int Id;
    public String Nombre;
    public String Categoria;
    public String Nombre_Autor;
    public String Ruta_Formulario;
    public String Ruta_Foto;
    public String Imagen;

    public enum Estado
    {
        Valida,
        Rechazada,
        aModificar,
        Pendiente
    };
    public Estado estado;



    public Receta()
    {
        Nombre = null;
        Categoria = null;
        Nombre_Autor = null;
        Ruta_Formulario = null;
    }

    public Receta(String Nom, String Categ, String Nombre_Aut, String Ruta_Form, String Ruta_Fot)
    {
        Nombre = Nom;
        Categoria = Categ;
        Nombre_Autor = Nombre_Aut;
        Ruta_Formulario = Ruta_Form;
    }

    public void ModificarReceta(String nomb, String categ, String nombre, String Ruta_Form)
    {
        Nombre = nomb;
        Categoria = categ;
        Nombre_Autor = nombre;
        Ruta_Formulario = Ruta_Form;
    }

    public void anadirImagen(String path)
    {
        Imagen = path;
    }
}