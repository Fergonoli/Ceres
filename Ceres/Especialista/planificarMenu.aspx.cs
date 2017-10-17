using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class planificarMenu : System.Web.UI.Page
{
   // Menu menu = new Menu();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        String Texto = Convert.ToString(Menu.verPlato(0))+", "
            + Convert.ToString(Menu.verPlato(1))+", "
            + Convert.ToString(Menu.verPlato(2))+", "
            + Convert.ToString(Menu.verPlato(3))+", "
            + Convert.ToString(Menu.verPlato(4))+", "
            + Convert.ToString(Menu.verPlato(5));
        Label7.Text=Texto;
        if (Menu.verPlato(0) != 0 && Menu.verPlato(1) != 0 && Menu.verPlato(2) != 0 && Menu.verPlato(3) != 0 &&
            Menu.verPlato(4) != 0 && Menu.verPlato(5) != 0)
        {
            for (int i = 0; i < 6; i++)
            {
                Menu.insertarDesayuno(0);
                Menu.insertarPlato1(0);
                Menu.insertarPlato2(0);
                Menu.insertarPostre1(0);
                Menu.insertarCena(0);
                Menu.insertarPostre2(0);
            }
        }
        if (Menu.verPlato(0) == 0)
        {
            Label1.Text = "Elige el desayuno";
            tablaDesayuno.Visible = true;
            Label2.Text = "No has elegido el primer plato de la comida";
            tablaPlato1.Visible = false;
            Label3.Text = "No has elegido el segundo plato de la comida";
            tablaPlato2.Visible = false;
            Label4.Text = "No has elegido el postre de la comida";
            tablaPostre1.Visible = false;
            Label5.Text = "No has elegido la cena";
            tablaPlato3.Visible = false;
            Label6.Text = "No has elegido el postre de la cena";
            tablaPostre2.Visible = false;
        }
        else
        {
            if (Menu.verPlato(1) == 0)
            {
                Label1.Text = "Ya has elegido el desayuno";
                tablaDesayuno.Visible = false;
                Label2.Text = "Elige el primer plato de la comida";
                tablaPlato1.Visible = true;
                Label3.Text = "No has elegido el segundo plato de la comida";
                tablaPlato2.Visible = false;
                Label4.Text = "No has elegido el postre de la comida";
                tablaPostre1.Visible = false;
                Label5.Text = "No has elegido la cena";
                tablaPlato3.Visible = false;
                Label6.Text = "No has elegido el postre de la cena";
                tablaPostre2.Visible = false;
            }
            else
            {
                if (Menu.verPlato(2) == 0)
                {
                    Label1.Text = "Ya has elegido el desayuno";
                    tablaDesayuno.Visible = false;
                    Label2.Text = "Ya has elegido el primer plato de la comida";
                    tablaPlato1.Visible = false;
                    Label3.Text = "Elige el segundo plato de la comida";
                    tablaPlato2.Visible = true;
                    Label4.Text = "No has elegido el postre de la comida";
                    tablaPostre1.Visible = false;
                    Label5.Text = "No has elegido la cena";
                    tablaPlato3.Visible = false;
                    Label6.Text = "No has elegido el postre de la cena";
                    tablaPostre2.Visible = false;
                }
                else
                {
                    if (Menu.verPlato(3) == 0)
                    {
                        Label1.Text = "Ya has elegido el desayuno";
                        tablaDesayuno.Visible = false;
                        Label2.Text = "Ya has elegido el primer plato de la comida";
                        tablaPlato1.Visible = false;
                        Label3.Text = "Ya has elegido el segundo plato de la comida";
                        tablaPlato2.Visible = false;
                        Label4.Text = "Elige el postre de la comida";
                        tablaPostre1.Visible = true;
                        Label5.Text = "No has elegido la cena";
                        tablaPlato3.Visible = false;
                        Label6.Text = "No has elegido el postre de la cena";
                        tablaPostre2.Visible = false;
                    }
                    else
                    {
                        if (Menu.verPlato(4) == 0)
                        {
                            Label1.Text = "Ya has elegido el desayuno";
                            tablaDesayuno.Visible = false;
                            Label2.Text = "Ya has elegido el primer plato de la comida";
                            tablaPlato1.Visible = false;
                            Label3.Text = "Ya has elegido el segundo plato de la comida";
                            tablaPlato2.Visible = false;
                            Label4.Text = "Ya has elegido el postre de la comida";
                            tablaPostre1.Visible = false;
                            Label5.Text = "Elige la cena";
                            tablaPlato3.Visible = true;
                            Label6.Text = "No has elegido el postre de la cena";
                            tablaPostre2.Visible = false;
                        }
                        else
                        {
                            if (Menu.verPlato(5) == 0)
                            {
                                Label1.Text = "Ya has elegido el desayuno";
                                tablaDesayuno.Visible = false;
                                Label2.Text = "Ya has elegido el primer plato de la comida";
                                tablaPlato1.Visible = false;
                                Label3.Text = "Ya has elegido el segundo plato de la comida";
                                tablaPlato2.Visible = false;
                                Label4.Text = "Ya has elegido el postre de la comida";
                                tablaPostre1.Visible = false;
                                Label5.Text = "Ya has elegido la cena";
                                tablaPlato3.Visible = false;
                                Label6.Text = "Elige el postre de la cena";
                                tablaPostre2.Visible = true;
                            }
                        }
                    }
                }
            }
        }
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void tablaDesayuno_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "insertaDesayuno")
        {
            int numFila = -1;
            int.TryParse(e.CommandArgument as string, out numFila);
            GridViewRow filaActual = this.tablaDesayuno.Rows[numFila];
            int idReceta = int.Parse(filaActual.Cells[0].Text);
            Menu.insertarDesayuno(idReceta);
            Label8.Text = Convert.ToString(Menu.verPlato(0));
        }
    }
    protected void tablaPlato1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "insertaPlato1")
        {
            int numFila = -1;
            int.TryParse(e.CommandArgument as string, out numFila);
            GridViewRow filaActual = this.tablaPlato1.Rows[numFila];
            int idReceta = int.Parse(filaActual.Cells[0].Text);
            Menu.insertarPlato1(idReceta);
            Label8.Text = Convert.ToString(Menu.verPlato(1));
        }
    }
    protected void tablaPlato2_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "insertaPlato2")
        {
            int numFila = -1;
            int.TryParse(e.CommandArgument as string, out numFila);
            GridViewRow filaActual = this.tablaPlato2.Rows[numFila];
            int idReceta = int.Parse(filaActual.Cells[0].Text);
            Menu.insertarPlato2(idReceta);
            Label8.Text = Convert.ToString(Menu.verPlato(2));
        }
    }
    protected void tablaPostre1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "insertaPostre1")
        {
            int numFila = -1;
            int.TryParse(e.CommandArgument as string, out numFila);
            GridViewRow filaActual = this.tablaPostre1.Rows[numFila];
            int idReceta = int.Parse(filaActual.Cells[0].Text);
            Menu.insertarPostre1(idReceta);
            Label8.Text = Convert.ToString(Menu.verPlato(3));
        }
    }
    protected void tablaPlato3_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "insertaPlato3")
        {
            int numFila = -1;
            int.TryParse(e.CommandArgument as string, out numFila);
            GridViewRow filaActual = this.tablaPlato3.Rows[numFila];
            int idReceta = int.Parse(filaActual.Cells[0].Text);
            Menu.insertarCena(idReceta);
            Label8.Text = Convert.ToString(Menu.verPlato(4));
        }
    }
    protected void tablaPostre2_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "insertaPostre2")
        {
            int numFila = -1;
            int.TryParse(e.CommandArgument as string, out numFila);
            GridViewRow filaActual = this.tablaPostre2.Rows[numFila];
            int idReceta = int.Parse(filaActual.Cells[0].Text);
            Menu.insertarPostre2(idReceta);
            Label8.Text = Convert.ToString(Menu.verPlato(5));
        }
    }
    protected void subirMenu_Click(object sender, EventArgs e)
    {
        
    }
}