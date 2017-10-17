using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HiloValorarReceta : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void TextBoxPuntuacion_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {

    }
    protected void ButtonValorar_Click(object sender, EventArgs e)
    {
        Almacenaje almacenaje = new Almacenaje(); 
        Usuario us = almacenaje.devuelveUsuario(Request.Cookies["userName"].Value);
        LabelErrorPuntuacion1.Visible = false;
        LabelAdecuacion.Visible = false;
        LabelErrorPuntuacion.Visible = false;
        LabelMensaje.Visible = false;

        if (TextBoxPuntuacion.Text == "")
        {
            LabelErrorPuntuacion1.Visible = true;
            return;
        }

        else {
       foreach(char c in TextBoxPuntuacion.Text)
        {
            if (c < 48 || c > 57)
            {
                LabelAdecuacion.Visible = true;
                return;
            }
        }
       if (Convert.ToInt32(TextBoxPuntuacion.Text) < 0 || Convert.ToInt32(TextBoxPuntuacion.Text) > 10)
       {
           LabelErrorPuntuacion.Visible = true;
           return;
       }
            almacenaje.InsertarComentario(TextBoxComentario.Text, us.ID, Convert.ToInt32(Request.QueryString["Id_Receta"]), Convert.ToInt32(TextBoxPuntuacion.Text));
            LabelMensaje.Visible = true;
            

        
        }
    }
}