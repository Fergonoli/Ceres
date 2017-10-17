using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LogoOut.Visible = false;
        //Si el usuario no esta logeado en el sistema, no se muestra el panel con los enlaces
        if (Request.Cookies["UserName"] != null)
        {
            Label3.Text = "Bienvenido a la página, " + Request.Cookies["UserName"].Value;
            TextBox1.Visible = false;
            TextBox2.Visible = false;
            Button1.Visible = false;
            Label1.Visible = false;
            Label2.Visible = false;
            LogoOut.Visible = true;
            MensajePrivado.Visible = true;
            ValidarReceta.Visible = false;
            ValorarReceta.Visible = false;
            AñadirProducto.Visible = false;
           

            //Ocultar o no los botones según los privilegios
            Usuario auxUsuario = new Usuario();
            Almacenaje almacenaje = new Almacenaje();
            auxUsuario = almacenaje.devuelveUsuario(Request.Cookies["UserName"].Value);
            if (auxUsuario is Usuario)
            {
                Menu.Visible = false;
                Privilegios.Visible = true;
                Recetas.Visible = true;
                AceptarReceta.Visible = false;
                Alta.Visible = false;
                MensajePrivado.Visible = true;
                MensajesRecibidos.Visible = true;
                ValidarReceta.Visible = true;
                ValorarReceta.Visible = true;
                AñadirProducto.Visible = false;
                VerCatalogo.Visible = true;
          
            }
            if (auxUsuario is Administrador)
            {
                Menu.Visible = true;
                Privilegios.Visible = false;
                Recetas.Visible = true;
                AceptarReceta.Visible = true;
                Alta.Visible = false;
                MensajePrivado.Visible = true;
                MensajesRecibidos.Visible = true;
                ValidarReceta.Visible = true;
                ValorarReceta.Visible = true;
                AñadirProducto.Visible = true;
                VerCatalogo.Visible = false;
                
            }
            if (auxUsuario is Especialista)
            {
                Menu.Visible = true;
                Privilegios.Visible = true;
                Recetas.Visible = false;
                AceptarReceta.Visible = true;
                Alta.Visible = false;
                MensajePrivado.Visible = true;
                MensajesRecibidos.Visible = true;
                ValidarReceta.Visible = true;
                ValorarReceta.Visible = true;
                AñadirProducto.Visible = false;
                VerCatalogo.Visible = true;
              
            }
            if (auxUsuario is Restaurante)
            {
                Menu.Visible = true;
                Privilegios.Visible = true;
                Recetas.Visible = true;
                AceptarReceta.Visible = false;
                Alta.Visible = false;
                MensajePrivado.Visible = true;
                MensajesRecibidos.Visible = true;
                ValidarReceta.Visible = true;
                ValorarReceta.Visible = true;
                AñadirProducto.Visible = false;
                VerCatalogo.Visible = true;
            }
            if (auxUsuario == null)
            {
                Menu.Visible = false;
                Privilegios.Visible = false;
                Recetas.Visible = false;
                AceptarReceta.Visible = false;
                Alta.Visible = true;
                MensajePrivado.Visible = false;
                MensajesRecibidos.Visible = false;
                ValidarReceta.Visible = false;
                ValorarReceta.Visible = false;
                AñadirProducto.Visible = false;
                VerCatalogo.Visible = true;
;
            }
           
            
        }
            //Si está logeado se muestra el panel, aunque los enlaces se controlan individualmente
        else
        {
            Label1.Visible = true;
            Label2.Visible = true;
            TextBox1.Visible = true;
            TextBox2.Visible = true;
            Button1.Visible = true;
            LogoOut.Visible = false;
            Label3.Visible = false;
            Panel1.Visible = true;
            Menu.Visible = false;
            Privilegios.Visible = false;
            Recetas.Visible = false;
            AceptarReceta.Visible = false;
            Alta.Visible = true;
            MensajePrivado.Visible = false;
            MensajesRecibidos.Visible = false;
            ValidarReceta.Visible = false;
            ValorarReceta.Visible = false;
            AñadirProducto.Visible = false;
            VerCatalogo.Visible = false;
        }


           

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Almacenaje almacenaje = new Almacenaje();

        /*Response.Cookies["userName"].Value = TextBox1.Text;
        Response.Cookies["userName"].Expires = DateTime.Now.AddHours(2);      
        
        */
        if (almacenaje.devuelveUsuario(TextBox1.Text) == null)
        {
            Label3.Visible = true;
            Label3.Text = "No existe el usuario";
        }
        else{
        
            if (almacenaje.devuelveUsuario(TextBox1.Text).Contrasena == TextBox2.Text)
            {
                Response.Cookies["userName"].Value = TextBox1.Text;
                Response.Cookies["userName"].Expires = DateTime.Now.AddHours(2d);
                Response.Redirect("./");
            }
            else{
                Label3.Visible = true;
                Label3.Text = "La contraseña no es válida";
            }
        }
       
        //Si hay cookie
        //TextBox1 y TextBox2 son invisibles
        //Label1 = Username     
        
        
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void LogoOut_Click(object sender, EventArgs e)
    {
        Response.Cookies["userName"].Value = "";
        Response.Cookies["userName"].Expires = DateTime.Now.AddMilliseconds(1d);
        Response.Redirect("./");
    }
}

/*
if(Request.Cookies["userName"] != null)
    Label1.Text = Server.HtmlEncode(Request.Cookies["userName"].Value);
*/