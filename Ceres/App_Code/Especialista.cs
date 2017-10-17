using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Especialista
/// </summary>
public class Especialista : Usuario
{
    public String N_colegiado{ get;set;}

	public Especialista():base()
	{        
        N_colegiado = null;
	}

    public Especialista(String Nom, String Ape1, String Ape2, String Ali, String N_cole)
    {
        Nombre = Nom;
        Apellido1 = Ape1;
        Apellido2 = Ape2;
        Alias = Ali;
        N_colegiado = N_cole;
    }

    public void Validar(Receta Recet)
    {
        if (Recet.estado != Receta.Estado.Valida)
        {
            Recet.estado = Receta.Estado.Valida;
            Almacenaje almacenamiento = new Almacenaje();
            Usuario usuario = new Usuario();
            usuario = almacenamiento.devuelveUsuario(Recet.Nombre_Autor);
            almacenamiento.ModificarReceta(Recet.Nombre, Recet.Categoria, usuario.ID, Recet.Ruta_Formulario, Convert.ToInt16(Recet.estado), Recet.Id);
            almacenamiento.AlmacenarRecetaConfirmada(Recet.Id, DateTime.Now);
        }
       
    }

    public void Rechazar(Receta Recet)
    {
        if (Recet.estado == Receta.Estado.Pendiente)
        {
            Recet.estado = Receta.Estado.Rechazada;

            Almacenaje almacenamiento = new Almacenaje();
            
            Usuario usuario = new Usuario();
            
            usuario=almacenamiento.devuelveUsuario(Recet.Nombre_Autor);

            almacenamiento.ModificarReceta(Recet.Nombre, Recet.Categoria, usuario.ID, Recet.Ruta_Formulario, Convert.ToInt16(Recet.estado), Recet.Id);

        }

    }

    public void aModificar(Receta Recet, String Error)
    {
        Recet.estado = Receta.Estado.aModificar;

        Almacenaje almacenamiento = new Almacenaje();
        
        Usuario usuario = new Usuario();
        usuario=almacenamiento.devuelveUsuario(Recet.Nombre_Autor);

        almacenamiento.ModificarReceta(Recet.Nombre, Recet.Categoria, usuario.ID, Recet.Ruta_Formulario, Convert.ToInt16(Recet.estado), Recet.Id);


        almacenamiento.AlmacenarRecetaAModificar(Recet.Id, Error);

    }
}