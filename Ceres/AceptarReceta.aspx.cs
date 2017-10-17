using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AceptarReceta : System.Web.UI.Page
{
    Receta aux;
    static int idRec;
    static String recep;
    Especialista esp = new Especialista();

    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = "";
        Error.Visible = false;
        Enviar.Visible = false;
    }
   
    
    protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
    {

    }

    protected void GridView1_RowCommand(Object sender, GridViewCommandEventArgs e)
    {
        aux = new Receta();
        

        if (e.CommandName == "Agregar")
        {
            //Modificar la receta id = e.CommandArgument;            
            GridViewRow a = GridView1.Rows[Convert.ToInt32(e.CommandArgument)];
            
            Almacenaje almacenaje = new Almacenaje();
            aux = almacenaje.recuperaReceta(Convert.ToInt32(a.Cells[0].Text));

            Label1.Text = "Aceptada la receta      " + aux.Id+"        " +aux.Nombre+   "          "  +aux.Ruta_Formulario;
            esp.Validar(aux);

            Response.Redirect("./AceptarReceta.aspx");

        }
        if (e.CommandName == "Modificar")
        {
            GridViewRow a = GridView1.Rows[Convert.ToInt32(e.CommandArgument)];
            Label1.Text = "Modificar la receta " + a.Cells[0].Text+" de "+a.Cells[3].Text+"\n Escribe en el siguiente cuadro el error.";
            idRec = int.Parse(a.Cells[0].Text);
            Error.Visible = true;
            Enviar.Visible = true;
            recep = a.Cells[3].Text;
        }
        if (e.CommandName == "Rechazar")
        {
            GridViewRow a = GridView1.Rows[Convert.ToInt32(e.CommandArgument)];
            Label1.Text = "Rechazada la receta " + a.Cells[0].Text;
            Almacenaje almacenaje = new Almacenaje();
            aux = almacenaje.recuperaReceta(Convert.ToInt32(a.Cells[0].Text));

            //Label1.Text = "ID"+aux.Id+"Nombre"+aux.Nombre+"Autor"+aux.Nombre_Autor+"IDUsuario";

            esp.Rechazar(aux);

            Response.Redirect("./AceptarReceta.aspx");

        }
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Almacenaje almacenaje = new Almacenaje();
        aux = almacenaje.recuperaReceta(idRec);
        Usuario UsuarioE = new Usuario();
        Usuario UsuarioR = new Usuario();

        UsuarioE = almacenaje.devuelveUsuario(Request.Cookies["userName"].Value);
        UsuarioR = almacenaje.devuelveUsuario(recep);
       
        Mensaje_Privado Mensaje = new Mensaje_Privado(UsuarioE.ID, UsuarioR.ID, "Modificar receta", Error.Text, DateTime.Now);
        Mensaje.enviarMensajePrivado();
        esp.aModificar(aux, Error.Text);
        Response.Redirect("./AceptarReceta.aspx");
    }
}