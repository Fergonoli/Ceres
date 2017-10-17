using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class aceptarCambio : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Almacenaje almacenaje = new Almacenaje();
        Usuario Usuario = new Usuario();
        Usuario = almacenaje.devuelveUsuario(Request.Cookies["userName"].Value);

        switch (Request.QueryString.Count)
        {
            case 1:
                Administrador.cambiarPrivilegiosAUsuario(Request.QueryString["alias"]);
                Usuario Usuario2 = new Usuario();
                Usuario2 = almacenaje.devuelveUsuario(Request.QueryString["alias"]);
                Mensaje_Privado Mensaje = new Mensaje_Privado(Usuario.ID, Usuario2.ID, "Realizado cambio de privilegios",
                "Tus privilegios han sido modificados a Usuario", DateTime.Now);
                Mensaje.enviarMensajePrivado();
                cambioAceptado.Text = "El usuario "+Usuario2.Alias+" ha cambiado a Usuario";
                break;
            case 2:
                Administrador.cambiarPrivilegiosAEspecialista(Request.QueryString["alias"], Request.QueryString["nocolegiado"]);
                Usuario Usuario3 = new Usuario();
                Usuario3 = almacenaje.devuelveUsuario(Request.QueryString["alias"]);
                Mensaje_Privado Mensaje1 = new Mensaje_Privado(Usuario.ID, Usuario3.ID, "Realizado cambio de privilegios",
                "Tus privilegios han sido modificados a Especialista", DateTime.Now);
                Mensaje1.enviarMensajePrivado();
                cambioAceptado.Text = "El usuario " + Usuario3.Alias + " ha cambiado a Especialista con número de colegiado " + Request.QueryString["nocolegiado"];
                break;
            case 3:
                Administrador.cambiarPrivilegiosARestaurante(Request.QueryString["alias"], Request.QueryString["Direccion"], float.Parse(Request.QueryString["Precio"]));
                Usuario Usuario4 = new Usuario();
                Usuario4 = almacenaje.devuelveUsuario(Request.QueryString["alias"]);
                Mensaje_Privado Mensaje2 = new Mensaje_Privado(Usuario.ID, Usuario4.ID, "Realizado cambio de privilegios",
                "Tus privilegios han sido modificados a Restaurante", DateTime.Now);
                Mensaje2.enviarMensajePrivado();
                cambioAceptado.Text = "El usuario " + Usuario4.Alias + " ha cambiado a Restaurante con dirección "
                    + Request.QueryString["Direccion"]+" y precio medio por menú "+float.Parse(Request.QueryString["Precio"]+" euros");
                break;
        }
    }
}