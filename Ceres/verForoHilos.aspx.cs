using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["UserName"] == null)
        {
            Panel2.Visible = false;
        }

    }
    protected void Enviar_Click(object sender, EventArgs e)
    {
        InstruccionesCrearTema.Visible = true;
        MensajeForo mens = new MensajeForo();
        Almacenaje almacenaje = new Almacenaje();

        mens.redactarNuevoHilo(almacenaje.devuelveUsuario(Request.Cookies["userName"].Value).ID, Asunto.Text, Texto.Text);
        Response.Redirect("./verForoHilos.aspx");        
    }
    protected void Asunto_TextChanged(object sender, EventArgs e)
    {

    }
}