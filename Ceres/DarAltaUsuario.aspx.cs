using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DarAltaUsuario : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

        //Los campos de errores deben aparecer ocultos hasta llegado el momento de
        //mostralos cuando haya algun errorcete


        //Los datos que se introducen en los privilegios deben aparecer solamente cuando
        //se piquen los checkbox
        //Restaurante
        Direccion.Visible = false;
        TextDireccion.Visible = false;
        Precio.Visible = false;
        TextPrecio.Visible = false;

        //Especialista
        N_Colegiado.Visible = false;
        TextN_Colegiado.Visible = false;


    }


    protected void Usuario_CheckedChanged(object sender, EventArgs e)
    {
        Restaurante.Checked = false;
        Especialista.Checked = false;

        //Los datos que se introducen en los privilegios deben aparecer solamente cuando
        //se piquen los checkbox
        //Restaurante
        Direccion.Visible = false;
        TextDireccion.Visible = false;
        Precio.Visible = false;
        TextPrecio.Visible = false;

        //Especialista
        N_Colegiado.Visible = false;
        TextN_Colegiado.Visible = false;

    }
    protected void Restaurante_CheckedChanged(object sender, EventArgs e)
    {
        Usuario.Checked = false;
        Especialista.Checked = false;

        //Los datos que se introducen en los privilegios deben aparecer solamente cuando
        //se piquen los checkbox
        //Restaurante
        Direccion.Visible = true;
        TextDireccion.Visible = true;
        Precio.Visible = true;
        TextPrecio.Visible = true;

        //Especialista
        N_Colegiado.Visible = false;
        TextN_Colegiado.Visible = false;
    }
    protected void Especialista_CheckedChanged(object sender, EventArgs e)
    {
        Usuario.Checked = false;
        Restaurante.Checked = false;

        //Los datos que se introducen en los privilegios deben aparecer solamente cuando
        //se piquen los checkbox
        //Restaurante
        Direccion.Visible = false;
        TextDireccion.Visible = false;
        Precio.Visible = false;
        TextPrecio.Visible = false;

        //Especialista
        N_Colegiado.Visible = true;
        TextN_Colegiado.Visible = true;
    }



    protected void Registrar_Click(object sender, EventArgs e)
    {
        //Comprobamos que el usuario no existe en la base de datos
        //Buscamos el usuario en la base de datos si no lo encuentra 
        //devuelve un nulo


        //Comprobacion de que todos los campos esten rellenos
        if(TextAlias.Text!="" &&
           TextApellido1.Text!="" &&
           TextApellido2.Text!="" &&
           TextContraseña.Text!="" &&
           TextCorreoElectronico.Text!="" &&
           TextFechaNamicimiento.Text!="" &&
           TextNombre.Text!="" &&
           TextReContraseña.Text!="")
        {

            Almacenaje almacenaje = new Almacenaje();
            Usuario a;
            a = almacenaje.devuelveUsuario(TextAlias.Text);

            //Comprobacion de alias disponible
            if (a == null)
            {
                Error_Alias.Visible = false;
                Error_Contraseña.Visible = false;
                Error_ReContraseña.Visible = false;

                //Comprobacion de que las dos contraseñas contienen el mismo string
                if (TextContraseña.Text.Equals(TextReContraseña.Text))
                {
                    Error_Contraseña.Visible = false;
                    Error_ReContraseña.Visible = false;
                    //RECONOCIMIENTOOOOOOOOOOOO
                    if(true)
                    {

                           if(Restaurante.Checked)
                            {
                                //Registramos momentaneamente al Restaurante como usuario normal
                                //No puede realziarse el cambio de privilegios directamente hasta
                                //que el administrador no compruebe los datos
                                Usuario b = new Usuario();
                                b.AltaUsuario(TextAlias.Text, TextNombre.Text, TextApellido1.Text, TextApellido2.Text, TextContraseña.Text);
                                
                                Almacenaje Almacenaje = new Almacenaje();
                                b=Almacenaje.devuelveUsuario(TextAlias.Text);

                                Mensaje_Privado Mensaje = new Mensaje_Privado(b.ID, 1, "Resgistrado como Restaurante", "El usuario: "+TextAlias.Text+
                                    " , desea registrase con privilegios de Restaurante, su negocio se encuentra en la calle/ "+TextDireccion.Text+" y el precio medio de sus menus es de "
                                    +TextPrecio.Text, DateTime.Now);

                                Mensaje.enviarMensajePrivado();
                                Response.Redirect("./");
 
                            }

                            //Comprobar que el N_colegiado sea un Numero
                            if(Especialista.Checked)
                            {
                                //Registramos momentaneamente al Especialista como usuario normal
                                //No puede realziarse el cambio de privilegios directamente hasta
                                //que el administrador no compruebe los datos
                                Usuario b = new Usuario();
                                b.AltaUsuario(TextAlias.Text, TextNombre.Text, TextApellido1.Text, TextApellido2.Text, TextContraseña.Text);
                                
                                Almacenaje Almacenaje = new Almacenaje();
                                b=Almacenaje.devuelveUsuario(TextAlias.Text);

                                Mensaje_Privado Mensaje = new Mensaje_Privado(b.ID, 1, "Resgistrado como Especialista", "El usuario: "+TextAlias.Text+
                                    " , desea registrase con privilegios de Especialista, su Numero de Colegiado es: "+TextN_Colegiado.Text, DateTime.Now);

                                Mensaje.enviarMensajePrivado();
                                Response.Redirect("./");
    
                            }
                                                        
                            if(Usuario.Checked)
                            {
                                //Resgistrar al usuario
                                Usuario b = new Usuario();
                                b.AltaUsuario(TextAlias.Text, TextNombre.Text, TextApellido1.Text, TextApellido2.Text, TextContraseña.Text);
                                Response.Redirect("./");
                            }                

                    }
                    else
                    {
                        //Reconocimiento Humano no superado NO ES UNA PERSONAAAAAAAAAA

                        
                    }
                }
                else
                {
                    //Las contraseñas no son iguales 

                    Error_Contraseña.Visible=true;
                    Error_Contraseña.Text="Contraseña incorrecta";
                    TextContraseña.Text="";

                    Error_ReContraseña.Visible=true;
                    Error_ReContraseña.Text="Contraseña incorrecta";
                    TextReContraseña.Text="";
                    if (a == null)
                    {
                        Error_Alias.Visible = false;

                    }

                }

            }
            else
            {
                //Alias ocupado no vale
                Error_Alias.Visible=true;
                Error_Alias.Text="Alias ocupado, prueba con otro";
                TextAlias.Text="";

                if (TextContraseña.Text.Equals(TextReContraseña.Text))
                {
                    Error_Contraseña.Visible = false;
                    Error_ReContraseña.Visible = false;
                }
                

            }
        }
        else
        {
            //ALIAS
            if (TextAlias.Text == "")
            {
                Error_Alias.Visible = true;
                Error_Alias.Text = "Esta vacio";
            }
            else
            {
                Error_Alias.Visible = false;
            }


            //APELLIDO1
           if(TextApellido1.Text=="")
           {
               Error_PrimerApellido.Visible=true;
               Error_PrimerApellido.Text="Esta vacio";
           }
           else
           {
               Error_PrimerApellido.Visible = false;
           }


           //APELLIDO2
           if(TextApellido2.Text=="")
           {
               Error_ApellidoSegundo.Visible=true;
               Error_ApellidoSegundo.Text="Esta vacio";
           }
           else
           {
               Error_ApellidoSegundo.Visible = false;
           }


           //CONTRASEÑA
           if(TextContraseña.Text=="") 
           {
               Error_Contraseña.Visible=true;
               Error_Contraseña.Text="Esta vacio";
           }
           else
           {
               Error_Contraseña.Visible = false;
           }


           //CORREO ELECTRONICO
           if(TextCorreoElectronico.Text=="")
           {
               Error_CorreoElectronico.Visible=true;
               Error_CorreoElectronico.Text="Esta vacio";

           }
           else
           {
               Error_CorreoElectronico.Visible = false;
           }


           //FECHA DE NACIMIENTO
           if(TextFechaNamicimiento.Text=="")
           {
               Error_Nacimiento.Visible=true;
               Error_Nacimiento.Text="Esta vacio";
           }
           else
           {
               Error_Nacimiento.Visible = false;
           }


           //NOMBRE
           if(TextNombre.Text=="")
           {
               Error_Nombre.Visible=true;
               Error_Nombre.Text="Esta vacio";
           }
           else
           {
               Error_Nombre.Visible = false;
           }


           //RECONTRASEÑA
           if(TextReContraseña.Text=="")
           {
               Error_ReContraseña.Visible=true;
               Error_ReContraseña.Text="Esta vacio";
           }
           else
           {
               Error_ReContraseña.Visible = false;
           }

        }
     }   
}
