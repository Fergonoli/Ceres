using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class verMensajesPrivados : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String cad;

        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            cad = GridView1.Rows[i].Cells[2].Text;
            cad = cad.Replace('{','<');
            cad = cad.Replace('}', '>');
            GridView1.Rows[i].Cells[2].Text=cad;
        }
    }
}