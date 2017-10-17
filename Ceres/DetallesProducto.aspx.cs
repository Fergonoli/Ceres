using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DetallesProducto : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Almacenaje almacenaje = new Almacenaje();

        Producto produc = new Producto(int.Parse(Request.QueryString["id"]));        

        TextBox_Descripcion_Producto.Text = produc.Descripcion;
        TextBox_Precio.Text = produc.Precio.ToString();
        TextBox_Nombre_Producto.Text = produc.Nombre;
        ErrorCantidad.Visible = false;
        ErrorStock.Visible = false;
        LabelAñadido.Visible=false;
        if (produc.Imagen == "")
            Image1.ImageUrl = "./imagenes/NOimagen.jpg";
        else
            Image1.ImageUrl = "./imagenes/"+produc.Imagen;
    }

    protected void ButtonAñadir_Click(object sender, EventArgs e)
    {
        Almacenaje a = new Almacenaje();
        Producto produc = new Producto(int.Parse(Request.QueryString["id"]));
        int idUsuario = a.devuelveUsuario(Request.Cookies["userName"].Value).ID;
        ErrorCantidad.Visible = false;
        if (TextBoxCantidad.Text == "" || TextBoxCantidad.Text[0] == ' ')
            ErrorCantidad.Visible = true;
        else
            if (double.Parse(TextBoxCantidad.Text) >= Int32.MaxValue)
            {
                ErrorCantidad.Visible = true;
                ErrorCantidad.Text = "Valor introducido fuera de rango";
            }
            else
            {
                int cant = Int32.Parse(TextBoxCantidad.Text);
                if (cant > produc.stock)
                {
                    ErrorStock.Text = "Solo disponemos de " + produc.stock + " unidades de este producto";
                    ErrorStock.Visible = true;
                }
                else
                {
                    if (a.pedidoUltimo(idUsuario) == -1)
                        a.insertaNuevoPedido(idUsuario);
                    a.insertaProductoEnPedido(a.pedidoUltimo(idUsuario), produc.identificador, int.Parse(TextBoxCantidad.Text));
                    ButtonAñadir.Visible = false;
                    LabelAñadido.Visible = true;
                }
        }   
    }
}