using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CheckOutCompra : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LabelConfirma.Visible = false;
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int pedido = int.Parse(Request.QueryString["pedido"]);
        if (e.CommandName == "borrar")
        {
            // Retrieve the row index stored in the 
            // CommandArgument property.
            int index = Convert.ToInt32(e.CommandArgument);

            // Retrieve the row that contains the button 
            // from the Rows collection.
            GridViewRow row = GridView1.Rows[index];

            // Add code here to add the item to the shopping cart.
            int NL = int.Parse(row.Cells[0].Text);

            Almacenaje a = new Almacenaje();
            a.borraProductoEnPedido(pedido,NL);
        }

    }

    protected void ButtonConfirmacion_Click(object sender, EventArgs e)
    {
        LabelConfirma.Visible = true;
        ButtonConfirmacion.Visible = false;
    }
}