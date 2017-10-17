using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

 
public partial class MostrarMensajeForo : System.Web.UI.Page
{
    Almacenaje aux = new Almacenaje();
    protected void Page_Load(object sender, EventArgs e)
    {
      
        LabelNoDestinatario.Visible = false;
        LabelAsunto.Visible = false;
        LabelMensaje.Visible = false;
        
        // si no se rellenan los campos de destinatario y mensaje, no se visualiza el boton Enviar Mensaje Privado
        //if (EscribirDestinatario.Text != "")
        //{
          //  if (EscribirMensajePrivado.Text != "")
            //{
                //EnviarMensajePrivado.Visible = true;
            //}
        //}
       
    }
   // protected void TextBox3_TextChanged(object sender, EventArgs e)
    //{
    //    // si no se rellenan los campos de destinatario y mensaje, no se visualiza el boton Enviar Mensaje Privado
    //    if (EscribirDestinatario.Text != "")
    //    {
    //        if (EscribirMensajePrivado.Text != "")
    //        {
    //            EnviarMensajePrivado.Visible = true;
    //        }
    //    }
    //}
    protected void EnviarMensajePrivado_Click(object sender, EventArgs e)
    {
        
        //necesitamos crear una base de datos donde almacenar los mensajes, 
        //convendría k tuviese los campos:
        //      emisor
        //      receptor
        //      mensaje en si
        //      fecha del mensaje y hora al ser posible ¿?

        //instancia del almacenamiento de los mensajes

        //_____________________.emisor = 
       
        //comprobar si el destinatario es un usuario del foro
        if (aux.devuelveUsuario(EscribirDestinatario.Text) == null)
        {
            LabelNoDestinatario.Visible = true;
            if (EscribeAsunto.Text == "")
            {
                LabelAsunto.Visible = true;
            }
            if (EscribeMensaje.Text == "")
            {
                LabelMensaje.Visible = true;
            }
        }
        else if (EscribeAsunto.Text=="") 
        {
            LabelAsunto.Visible = true;
            if (aux.devuelveUsuario(EscribirDestinatario.Text) == null)
            {
                LabelNoDestinatario.Visible = true;
            }
            else if (EscribeMensaje.Text == "")
            {
                LabelMensaje.Visible = true;
            }
        }
        else if (EscribeMensaje.Text == "")
        {
            LabelMensaje.Visible = true;
            if (aux.devuelveUsuario(EscribirDestinatario.Text) == null)
            {
                LabelNoDestinatario.Visible = true;
            }
            if (EscribeMensaje.Text == "")
            {
                LabelMensaje.Visible = true;
            }
        }
        else
        {
            //_____________________.receptor = EscribirDestinatario.Text;

            // ____________________.mensaje = EscribirMensajePrivado.Text;
            Almacenaje almacenaje = new Almacenaje();
            Usuario a, b;
            a = almacenaje.devuelveUsuario(Request.Cookies["UserName"].Value);
            b = almacenaje.devuelveUsuario(EscribirDestinatario.Text);
            Mensaje_Privado men = new Mensaje_Privado(a.ID, b.ID, EscribeAsunto.Text, EscribeMensaje.Text, DateTime.Now);
            men.enviarMensajePrivado();

            Response.Redirect("./");
        }
    }
}