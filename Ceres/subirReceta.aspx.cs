using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class subirReceta : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Texto_Error.Visible = false;
        Texto_Solucion.Visible = false;
        //Texto_Solucion.Text = "Value=" + Request.Cookies["UserName"].Value;

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //Acoger lo de la cookie
        Almacenaje almacenaje = new Almacenaje();
        Usuario a;
        String archivo;

        a = almacenaje.devuelveUsuario(Request.Cookies["UserName"].Value);
        Texto_Solucion.Visible = true;
        
        
        if(!(Nombre_receta.Text== ""))
        {
            if(!(Ingredientes.Text==""))
            {
                if(!(Elaboracion.Text==""))
                {
                    if (!SubidaImagen.FileName.Equals(String.Empty))
                    {
                        if(SubidaImagen.FileName.EndsWith(".png".ToLower()))
                        {
                            //Si la ruta no es vacia y esta finalizada en .png la ruta debe acabar en 
                            //png 
                            archivo = "Z:\\GA1-CERES\\trunk\\Implementacion\\imagenes\\"+almacenaje.maxid()+".png";
                            SubidaImagen.SaveAs(archivo);

                            a.SubirReceta(Nombre_receta.Text, tipoCategoria.Text, Ingredientes.Text + " \r\n" + Elaboracion.Text);
                        
                            //Tratamos la imagen por separado
                            if(!SubidaImagen.FileName.Equals(String.Empty))
                            {
                                almacenaje.anadirImagen(archivo, almacenaje.maxid()-1 );
                            }
                            Texto_Solucion.Text = "Receta enviada a revision por Especialista";
                            Texto_Solucion.Visible = true; 

                        }
                        if(SubidaImagen.FileName.EndsWith(".jpg".ToLower()))
                        {
                            //Si la ruta no es vacia y esta finalizada en .jpg la ruta debe acabar en 
                            //jpg                             
                            
                            archivo = System.IO.Path.GetFullPath("@imagenes") + almacenaje.maxid() + ".jpg";                            
                            SubidaImagen.SaveAs(archivo);

                            a.SubirReceta(Nombre_receta.Text, tipoCategoria.Text, Ingredientes.Text + " \r\n" + Elaboracion.Text);

                        
                            //Tratamos la imagen por separado
                            if(!SubidaImagen.FileName.Equals(String.Empty))
                            {
                                almacenaje.anadirImagen(archivo, almacenaje.maxid()-1 );                            
                            }
                            Texto_Solucion.Text = "Receta enviada a revision por Especialista";
                            Texto_Solucion.Visible = true;                            

                        }

                    }

 
                }
                else
                {
                    Texto_Error.Text = "Envio no realizado, falta por rellenar el campo Elaboracion";
                    Texto_Error.Visible = true;
                }
            }
            else
            {
                Texto_Error.Text = "Envio no realizado, falta por rellenar el campo Ingredientes";
                Texto_Error.Visible = true;
            }
            
        }
        else
        {
            Texto_Error.Text = "Envio no realizado, falta por rellenar el campo Nombre de la receta";
            Texto_Error.Visible = true;
        }
        

    }
}