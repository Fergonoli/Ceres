using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Administrador
/// </summary>
public class Administrador : Usuario
{

    public Administrador()
        : base()
    {
    }

    public enum tiposUsuario
    {
        usuario, administrador, especialista, restaurante
    }

    public Administrador(String Nom, String Ape1, String Ape2, String Ali)
    {
        Nombre = Nom;
        Apellido1 = Ape1;
        Apellido2 = Ape2;
        Alias = Ali;
    }

    //Solo se puede usar si el usuario es usuario plano, no garantizo que pete si lo usais con otro tipo de usuario
    public static  bool cambiarPrivilegiosAAdministrador(String alias)
    {
        Almacenaje claseAlmacenaje = new Almacenaje();
        Usuario usuario = claseAlmacenaje.devuelveUsuario(alias);
        cambiarPrivilegiosAUsuario(alias);
        claseAlmacenaje.insertaAdministrador(usuario.ID);        
        return true;
    }

    //Solo se puede usar si el usuario es usuario plano, no garantizo que pete si lo usais con otro tipo de usuario
    public static bool cambiarPrivilegiosAEspecialista(String alias, String numeroColegiado)
    {
        Almacenaje claseAlmacenaje = new Almacenaje();
        Usuario usuario = claseAlmacenaje.devuelveUsuario(alias);
        cambiarPrivilegiosAUsuario(alias);
        claseAlmacenaje.insertaEspecialista(usuario.ID, numeroColegiado);
        return true;
    }

    //Solo se puede usar si el usuario es usuario plano, no garantizo que pete si lo usais con otro tipo de usuario
    public static bool cambiarPrivilegiosARestaurante(String alias, String direccion, float precio)
    {
        Almacenaje claseAlmacenaje = new Almacenaje();
        Usuario usuario = claseAlmacenaje.devuelveUsuario(alias);
        cambiarPrivilegiosAUsuario(alias);
        claseAlmacenaje.insertaRestaurante(usuario.ID, direccion, precio);
        return true;
    }


    public static bool cambiarPrivilegiosAUsuario(String alias)
    {
        Almacenaje claseAlmacenaje = new Almacenaje();
        Usuario usuario =  claseAlmacenaje.devuelveUsuario(alias);
        if (usuario is Administrador)
        {
            claseAlmacenaje.borraPrivilegiosAdministrador(alias);
        }
        else if (usuario is Restaurante)
        {
            claseAlmacenaje.borraPrivilegiosRestaurante(alias);
        }
        else if (usuario is Especialista)
        {
            claseAlmacenaje.borraPrivilegiosEspecialista(alias);
        }
        //enviarMensaje(Usuario usuario, String contenido);     
        return true;
    }
}