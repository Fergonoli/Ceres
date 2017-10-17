using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data.SqlClient;

public partial class distribuirAlimento : System.Web.UI.Page
{
    G_Usuarios aux = new G_Usuarios();
    G_Producto g_prod = new G_Producto();
    G_Alimento g_alim = new G_Alimento();

    protected void Page_Load(object sender, EventArgs e)
    {
        Button4.Visible = false;
        aceptar.Visible = false;
        Label5.Visible = false;
        Label6.Visible = false;
        Label10.Visible = false;
        GridView1.Visible = false;
        GridView2.Visible = false;
        GridView3.Visible = false;
        Cantidad.Visible = false;
        Button2.Visible = false;
        Button3.Visible = false;
        Button5.Visible = false;
        Noencontrado.Visible = false;
        Resultado.Visible = false;
    }

    /*Despliega el calendario de la caducidad*/
    protected void Button4_Click(object sender, EventArgs e)
    {
        Caducidad.Visible = !Caducidad.Visible;
            if (Caducidad.Visible)
                Desplegar.Text = "Ocultar Calendario";
            else
                Desplegar.Text = "Desplegar Calendario";
    }

    /*Boton de Buscar*/
    protected void Button1_Click(object sender, EventArgs e)
    {
        /*Se hacen elementos visibles e invisibles según sea necesario*/
        Button4.Visible = false;
        aceptar.Visible = false;
        Label5.Visible = false;
        Label6.Visible = false;
        GridView1.DataBind();
        GridView1.Visible = true;
        GridView2.Visible = false;
        GridView3.Visible = false;
        Cantidad.Visible = false;
        Button2.Visible = false;
        Button3.Visible = false;
        Button5.Visible = false;
        if (GridView1.Rows.Count == 0)
            Noencontrado.Visible = true;
        else
            Noencontrado.Visible = false;
        Resultado.Visible = false;
    }

    /*Seleccionamos una solicitud*/
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label8.Text = "0";
        Label11.Text = "0";
        Label12.Text = "0";
        Label13.Text = "0";
        Label14.Text = "0";
        Label15.Text = "0";
        Label16.Text = "0";
        Label17.Text = "0";
        Label18.Text = "0";
        Label19.Text = "0";
        Label20.Text = "0";
        Label21.Text = "0";
        Label22.Text = "0";
        Label23.Text = "0";
        Label24.Text = "0";
        Label25.Text = "0";
        Label26.Text = "0";
        Label27.Text = "0";
        Label28.Text = "0";
        Label29.Text = "0";
        Label30.Text = "0";
        Label31.Text = "0";
        Label32.Text = "0";
        Label33.Text = "0";
        Label34.Text = "0";
        Label35.Text = "0";
        Label36.Text = "0";
        Label37.Text = "0";
        Label38.Text = "0";
        Label39.Text = "0";
        
        GridView1.Visible = true;
        GridViewRow row = GridView1.SelectedRow;
        Label7.Text = row.Cells[0].Text;
        Button4.Visible = true;
        aceptar.Visible = true;
        GridView2.Visible = true;
        GridView2.DataBind();

        for (int i = 0; i < GridView2.Rows.Count; i++)
        {
            if (Label8.Text == "0")
                Label8.Text = GridView2.Rows[i].Cells[0].Text;
            else if (Label11.Text == "0")
                Label11.Text = GridView2.Rows[i].Cells[0].Text;
            else if (Label12.Text == "0")
                Label12.Text = GridView2.Rows[i].Cells[0].Text;
            else if (Label13.Text == "0")
                Label13.Text = GridView2.Rows[i].Cells[0].Text;
            else if (Label14.Text == "0")
                Label14.Text = GridView2.Rows[i].Cells[0].Text;
            else if (Label15.Text == "0")
                Label15.Text = GridView2.Rows[i].Cells[0].Text;
            else if (Label16.Text == "0")
                Label16.Text = GridView2.Rows[i].Cells[0].Text;
            else if (Label17.Text == "0")
                Label17.Text = GridView2.Rows[i].Cells[0].Text;
            else if (Label18.Text == "0")
                Label18.Text = GridView2.Rows[i].Cells[0].Text;
            else if (Label19.Text == "0")
                Label19.Text = GridView2.Rows[i].Cells[0].Text;
            else if (Label20.Text == "0")
                Label20.Text = GridView2.Rows[i].Cells[0].Text;
            else if (Label21.Text == "0")
                Label21.Text = GridView2.Rows[i].Cells[0].Text;
            else if (Label22.Text == "0")
                Label22.Text = GridView2.Rows[i].Cells[0].Text;
            else if (Label23.Text == "0")
                Label23.Text = GridView2.Rows[i].Cells[0].Text;
            else if (Label24.Text == "0")
                Label24.Text = GridView2.Rows[i].Cells[0].Text;
            else if (Label25.Text == "0")
                Label25.Text = GridView2.Rows[i].Cells[0].Text;
            else if (Label26.Text == "0")
                Label26.Text = GridView2.Rows[i].Cells[0].Text;
            else if (Label27.Text == "0")
                Label27.Text = GridView2.Rows[i].Cells[0].Text;
            else if (Label28.Text == "0")
                Label28.Text = GridView2.Rows[i].Cells[0].Text;
            else if (Label29.Text == "0")
                Label29.Text = GridView2.Rows[i].Cells[0].Text;
            else if (Label30.Text == "0")
                Label30.Text = GridView2.Rows[i].Cells[0].Text;
            else if (Label31.Text == "0")
                Label31.Text = GridView2.Rows[i].Cells[0].Text;
            else if (Label32.Text == "0")
                Label32.Text = GridView2.Rows[i].Cells[0].Text;
            else if (Label33.Text == "0")
                Label33.Text = GridView2.Rows[i].Cells[0].Text;
            else if (Label34.Text == "0")
                Label34.Text = GridView2.Rows[i].Cells[0].Text;
            else if (Label35.Text == "0")
                Label35.Text = GridView2.Rows[i].Cells[0].Text;
            else if (Label36.Text == "0")
                Label36.Text = GridView2.Rows[i].Cells[0].Text;
            else if (Label37.Text == "0")
                Label37.Text = GridView2.Rows[i].Cells[0].Text;
            else if (Label38.Text == "0")
                Label38.Text = GridView2.Rows[i].Cells[0].Text;
            else if (Label39.Text == "0")
                Label39.Text = GridView2.Rows[i].Cells[0].Text;
        }

        GridView3.Visible = true;
        GridView3.DataBind();
    }

    /*Seleccionamos un producto y se habilita la cantidad*/
    protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridView1.Visible = true;
        GridView2.Visible = true;
        GridView3.Visible = true;
        GridViewRow row = GridView3.SelectedRow;

        Label5.Visible = true;
        Label6.Visible = true;
        Cantidad.Visible = true;
        Button2.Visible = true;
        Button3.Visible = true;
        Button4.Visible = true;
        Button5.Visible = true;
        aceptar.Visible = true;

        // Obtenemos id_alimento del producto
        int id_alimento = g_prod.DevuelveIDAporNombre(row.Cells[0].Text.ToString());
        string alimento = g_alim.DevuelvePorID(id_alimento);

        foreach (GridViewRow a in GridView2.Rows)
        {
            if (a.Cells[1].Text == alimento)
            {
                if (Convert.ToSingle(row.Cells[2].Text) >= Convert.ToSingle(a.Cells[2].Text))
                    Cantidad.Text = a.Cells[2].Text;
                else
                    Cantidad.Text = row.Cells[2].Text;
            }
        }

        // Habilitar campo cantidad
        Label5.Text = row.Cells[0].Text;
        Cantidad.Enabled = true;
    }

    /*Botón +*/
    protected void Button2_Click(object sender, EventArgs e)
    {
        GridView1.Visible = true;
        GridView2.Visible = true;
        GridView3.Visible = true;

        Label5.Visible = true;
        Label6.Visible = true;
        Cantidad.Visible = true;
        Button2.Visible = true;
        Button3.Visible = true;
        Button4.Visible = true;
        Button5.Visible = true;
        aceptar.Visible = true;

        /*Se coge la cantidad de cantidad y se le suma 1*/
        double valor;       
        valor = double.Parse(Cantidad.Text);
        valor = valor + 1;
        Cantidad.Text = valor.ToString();
    }

    /*Botón de -*/
    protected void Button3_Click(object sender, EventArgs e)
    {
        GridView1.Visible = true;
        GridView2.Visible = true;
        GridView3.Visible = true;

        Label5.Visible = true;
        Label6.Visible = true;
        Cantidad.Visible = true;
        Button2.Visible = true;
        Button3.Visible = true;
        Button4.Visible = true;
        Button5.Visible = true;
        aceptar.Visible = true;

        double valor;
        valor = double.Parse(Cantidad.Text);
        valor = valor - 1;
        Cantidad.Text = valor.ToString();
    }

    /*Botón aceptar cantidad*/
    protected void Button5_Click(object sender, EventArgs e)
    {
        GridView1.Visible = true;
        GridView2.Visible = true;
        GridView3.Visible = true;

        Label5.Visible = true;
        Label6.Visible = true;
        Cantidad.Visible = true;
        Button2.Visible = true;
        Button3.Visible = true;
        Button4.Visible = true;
        Button5.Visible = true;
        aceptar.Visible = true;

        GridViewRow row = GridView3.SelectedRow;

        if (Cantidad.Text == "")
            {
                Label10.Visible = true;
                Label10.Text = "El campo cantidad está vacío";
            }

            else
            {
                float cantidadDon = float.MaxValue;
                try // Capturamos la excepción de desbordar float
                {
                    cantidadDon = Convert.ToSingle(Cantidad.Text);
                }
                catch (OverflowException)
                {
                    Label10.Text = "Se ha superado el límite de float";
                }

                float cantidadDis = Convert.ToSingle(row.Cells[2].Text);

                if (cantidadDon > cantidadDis)
                {
                    Label10.Visible = true;
                    Label10.Text = "Has superado la cantidad disponible";
                }

                else
                {
                    //Introducir cantidad en tablas
                    row.Cells[4].Text = Cantidad.Text;
                    float cantidadT = 0;

                    // Obtenemos id_alimento del producto
                    int id_alimento = g_prod.DevuelveIDAporNombre(row.Cells[0].Text.ToString());
                    string alimento = g_alim.DevuelvePorID(id_alimento);

                    foreach (GridViewRow a in GridView2.Rows)
                    {
                        if (a.Cells[1].Text == alimento)
                        {
                            try
                            {
                                cantidadT = Convert.ToSingle(a.Cells[3].Text);
                            }
                            catch (FormatException)
                            { }
                            cantidadT = cantidadT + cantidadDon;
                            a.Cells[3].Text = cantidadT.ToString();
                        }
                    }
                //    try
                //    {
                //        cantidadT = Convert.ToSingle(rowS.Cells[4].Text);
                //    }
                //    catch (FormatException)
                //    {}
                //    cantidadT = cantidadT + cantidadDon;
                //    rowS.Cells[4].Text = cantidadT.ToString();
                }
            }
    }

    /*Rechazar solicitud*/
    protected void Button4_Click1(object sender, EventArgs e)
    {
        DataSetCU3TableAdapters.QueriesTableAdapter datos = new DataSetCU3TableAdapters.QueriesTableAdapter();
        datos.BorrarSolicitud(int.Parse(Label7.Text));
        datos.BorrarIdSolicitud(int.Parse(Label7.Text));
        Resultado.Visible = true;
        Resultado.Text = "La solicitud ha sido rechazada";
        Resultado.ForeColor = System.Drawing.Color.Red;
    }

    /*Aceptar solicitud*/
    protected void aceptar_Click(object sender, EventArgs e)
    {
        Resultado.Visible = true;
        Resultado.Text = "La solicitud ha sido aceptada";
        Resultado.ForeColor = System.Drawing.Color.Black;

        DataSetCU3TableAdapters.pedidoTableAdapter pedido = new DataSetCU3TableAdapters.pedidoTableAdapter();
        G_Solicitud g_sol = new G_Solicitud();
        //Insertamos el pedido
        int id_Dis = aux.DevuelveUsuario(Request.Cookies["UserName"].Value).ID_Usuario;
        GridViewRow row = GridView1.SelectedRow;
        int id_Sol = g_sol.DevolverUsuarioporSolicitud(Convert.ToInt32(row.Cells[0].Text));
        int id_S = Convert.ToInt32(row.Cells[0].Text);
        pedido.InsertarPedido(id_Dis, id_Sol, id_S);
        
        //Insertamos las líneas de pedido
        DataSetCU3TableAdapters.linea_pedido1TableAdapter lineaPedido = new DataSetCU3TableAdapters.linea_pedido1TableAdapter();
        DataSetCU3 local = new DataSetCU3();
        DataSetCU3TableAdapters.QueriesTableAdapter datos = new DataSetCU3TableAdapters.QueriesTableAdapter();
        int id_Ped = (int)datos.SelectUltimoPedido();

        float cantidad;
        for (int i = 0; i < GridView3.Rows.Count; i++)
        {
            try
            {
                cantidad = Convert.ToSingle(GridView3.Rows[i].Cells[4].Text);
            }
            catch (FormatException)
            {
                cantidad = 0;
            }

            if (cantidad != 0)
            {
                int id_prod = g_prod.DevuelveIDPporNombre(GridView3.Rows[i].Cells[0].Text);
                
                lineaPedido.InsertQuery(id_Ped, id_prod, (int?)cantidad);
                //Modificamos la cantidad del producto
                g_prod.UpdateCantidad(id_prod, (-1) * Convert.ToSingle(GridView3.Rows[i].Cells[4].Text));
                //Y del alimento
                int id_alimento = g_prod.DevuelveIDAporNombre(GridView3.Rows[i].Cells[0].Text.ToString());
                string alimento = g_alim.DevuelvePorID(id_alimento);
                
                foreach (GridViewRow a in GridView2.Rows)
                {
                    if (a.Cells[1].Text == alimento)
                        g_alim.ActualizaCantidad(id_alimento, (-1) * Convert.ToSingle(a.Cells[3].Text));
                }
            }
        }
    }   
}