using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cambiarPrivilegios : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label2.Text = "";
        Label3.Text = "";
        Label4.Text = "";
        NumColegiado.Visible = false;
        DirRestaurante.Visible = false;
        PrecioRestaurante.Visible = false;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Almacenaje almacenaje = new Almacenaje();
        Usuario Usuario = new Usuario();
        Usuario = almacenaje.devuelveUsuario(Request.Cookies["userName"].Value);


        if (RadioButtonList1.SelectedValue == "Especialista")
        {
            Mensaje_Privado Mensaje = new Mensaje_Privado(Usuario.ID, 1, "Cambio de Privilegios a Especialista",
                "El usuario: " + Usuario.Alias +
                " , desea cambiar sus privilegios a Especialista, su Numero de Colegiado es: " 
                + NumColegiado.Text + " {a href=./aceptarCambio.aspx?alias="+Usuario.Alias+
                "&nocolegiado="+NumColegiado.Text+ "}Aceptar cambios{/a}", DateTime.Now);

            Mensaje.enviarMensajePrivado();
        }
        if (RadioButtonList1.SelectedValue == "Restaurante")
        {
            Mensaje_Privado Mensaje = new Mensaje_Privado(Usuario.ID, 1, "Cambio de Privilegios a Restaurante", "El usuario: " + Usuario.Alias +
                " , desea cambiar sus privilegios a Restaurante, su Direccion es: " + DirRestaurante.Text+ " y su precio medio"+
                " por menu:"+PrecioRestaurante.Text +
                " {a href=./aceptarCambio.aspx?alias="+Usuario.Alias+"&Direccion="
                + DirRestaurante.Text.Replace(" ", "%20") + "&Precio=" + PrecioRestaurante.Text + "}Aceptar cambios{/a}", DateTime.Now);

            Mensaje.enviarMensajePrivado();
        }
        if (RadioButtonList1.SelectedValue != "Especialista" && RadioButtonList1.SelectedValue != "Restaurante")
        {
            Mensaje_Privado Mensaje = new Mensaje_Privado(Usuario.ID, 1, "Cambio de Privilegios a Usuario", "El usuario: " + Usuario.Alias +
                " , desea cambiar sus privilegios a Usuario" +
                " {a href=./aceptarCambio.aspx?alias="+Usuario.Alias + "}Aceptar cambios{/a}", DateTime.Now);

            Mensaje.enviarMensajePrivado();
        }

        Label1.Text = "Tu solicitud se ha enviado correctamente";
    }
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (RadioButtonList1.SelectedValue == "Especialista")
        {
            NumColegiado.Visible = true;
            Label2.Text = "Número de colegiado";
            Label3.Text = "";
            Label4.Text = "";
            DirRestaurante.Text = "";
            PrecioRestaurante.Text = "";
            
        }
        if (RadioButtonList1.SelectedValue == "Restaurante")
        {
            PrecioRestaurante.Visible = true;
            DirRestaurante.Visible = true;
            Label2.Text = "";
            Label3.Text = "Direccion (formato: Nombre de calle, número)";
            Label4.Text = "Precio";
            NumColegiado.Text = "";
        }
        if (RadioButtonList1.SelectedValue != "Especialista" && RadioButtonList1.SelectedValue != "Restaurante")
        {
            NumColegiado.Visible = false;
            DirRestaurante.Visible = false;
            PrecioRestaurante.Visible = false;
            Label2.Text = "";
            Label3.Text = "";
            Label4.Text = "";
            NumColegiado.Text = "";
            DirRestaurante.Text = "";
            PrecioRestaurante.Text = "";
        }

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void HiddenField1_ValueChanged(object sender, EventArgs e)
    {

    }
}