using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Collections;


public partial class verHilo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        Almacenaje almacenaje = new Almacenaje();        
        MensajeForo[] mens = almacenaje.devuelveMensajes(int.Parse(Request.QueryString["hilo"]));
        
        for (int i = 0; i < GridView1.Rows.Count; i++)
            GridView1.Rows[i].Cells[1].Text = "Asunto:" +  mens[i].asunto + System.Environment.NewLine + "\r\n" +"<br>" + mens[i].texto;
        //GridView1.Columns[2].Visible = false;
        //GridView1.Columns[3].Visible = false;


        if (Request.Cookies["UserName"] == null)
        {
            Panel2.Visible = false;
        }
    }


    protected void Responder_Click(object sender, EventArgs e)
    {        
        MensajeForo msg = new MensajeForo();
        Almacenaje almacenaje = new Almacenaje();
        Usuario us = almacenaje.devuelveUsuario(Request.Cookies["userName"].Value);
        msg.redactar(us.ID, Asunto.Text, Texto.Text, Convert.ToInt32(Request.QueryString[0]));
        Response.Redirect("./verHilo.aspx?hilo="+Request.QueryString["hilo"]);
        
    }
}