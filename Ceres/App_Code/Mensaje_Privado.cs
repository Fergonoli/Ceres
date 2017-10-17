using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Mensaje_Privado
/// </summary>
public class Mensaje_Privado
{
    int ID_MensajePrivado;
    int ID_emisor;
    int ID_receptor;
    protected String Texto;
    protected DateTime Fecha;
    protected String Asunto;

	public Mensaje_Privado()
	{
        ID_emisor = 0;
        ID_receptor = 0;
        Asunto = null;
        Texto = null;
        Fecha = DateTime.Now;
	}

	public Mensaje_Privado(int Usuario_env, int Usuario_rec, String Tem, String Text, DateTime Fech)
	{
        ID_emisor = Usuario_env;
        ID_receptor = Usuario_rec;
        Asunto = Tem;
        Texto = Text;
        Fecha = Fech;
	}

    public void enviarMensajePrivado(/*int ID_em, int ID_re, String Asun, String Mens, DateTime Fech*/)
    {
        Almacenaje a = new Almacenaje();
        a.AlmacenarMensajePrivado(ID_emisor, ID_receptor, Asunto, Texto, Fecha);
    }
}