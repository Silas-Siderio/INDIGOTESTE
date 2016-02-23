using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;



public partial class usr : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblusuario.Text = Convert.ToString(Session["NOME"]);
        if (lblusuario.Text == "admin")
        {  }
        if (lblusuario.Text == "comum")
        { }

    }



    protected void btnoff_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("Default.aspx");
    }
}

  


