using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de MensajeForo
/// </summary>
public class MensajeForo
{
    int id_mensaje;
    int id_emisor;
    DateTime Fecha;
    public String asunto;
    public String texto;
    int id_hilo;

    public MensajeForo()
    {   
    }
	public MensajeForo(int id_m, int id_em, DateTime fech, String asu, String text, int id_hil)
	{
		id_mensaje = id_m;
        id_emisor = id_em;
        Fecha = fech;
        asunto = asu;
        texto = text;
        id_hilo = id_hil;
	}

    public void redactar(int id_emisor_p, String asunto_p, String texto_p, int Id_hilo_p)
    {        
        id_emisor = id_emisor_p;
        Fecha = DateTime.Now;       
        asunto = asunto_p;
        texto = texto_p;
        id_hilo = Id_hilo_p;
        Almacenaje almacenaje = new Almacenaje();
        almacenaje.insertaMensajeForo(id_emisor, Fecha, asunto, texto, id_hilo);
    }

    public void redactarNuevoHilo(int id_emisor_p, String asunto_p, String texto_p)
    {
        id_emisor = id_emisor_p;
        Fecha = DateTime.Now;
        asunto = asunto_p;
        texto = texto_p;        
        Almacenaje almacenaje = new Almacenaje();
        almacenaje.inserNuevoHilo(id_emisor_p, DateTime.Now, asunto_p, texto_p);
    }

    public void modificar(String asunto_p, String Texto)
    {
        asunto = asunto_p;
        texto = Texto;
        texto += "\nModificado el dia" + Fecha.ToString();        
        Almacenaje almacenaje = new Almacenaje();
        almacenaje.modificaMensajeForo(Fecha, asunto, texto, id_mensaje);
    }

    

}