using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class verCatalogo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int i, filas = GridView1.Rows.Count;
        GridViewRow a;
        Almacenaje b = new Almacenaje();

        for (i = 0; i < filas; i++)
        {
            a = GridView1.Rows[i];
            if (a.Cells[1].Text == "&nbsp;")
                a.Cells[1].Text = "<img src=\"./imagenes/NOimagen.jpg\" height=\"100\">";
            else
                a.Cells[1].Text = "<img src=\"./imagenes/" + a.Cells[1].Text + "\" height=\"100\">";

            int idUsuario = b.devuelveUsuario(Request.Cookies["userName"].Value).ID;
            HyperLink1.NavigateUrl = "./CheckOutCompra.aspx?pedido=" + b.pedidoUltimo(idUsuario);
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void GridView1_RowCommand(Object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Acceder")
        {
            GridViewRow a = GridView1.Rows[Convert.ToInt32(e.CommandArgument)];
            String enlace = "./DetallesProducto.aspx?id="+a.Cells[0].Text;
            Response.Redirect(enlace);
        }
    }
}