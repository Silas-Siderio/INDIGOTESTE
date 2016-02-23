using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using INDIGOTESTE;


public partial class _Default : Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
     
    }

    protected void btnlogin_Click(object sender, EventArgs e)
    {
     
        LOGINUSUARIO  dados = new LOGINUSUARIO();

        if(dados.VERIFICAUSUARIO(txtusuario.Text ,txtsenha.Text).Rows.Count >0) 

       {
            Session["TIPO"] = dados.VERIFICAUSUARIO(txtusuario.Text, txtsenha.Text).Rows[0].ItemArray[0].ToString();
            Session["NOME"] = dados.VERIFICAUSUARIO(txtusuario.Text, txtsenha.Text).Rows[0].ItemArray[1].ToString();
            Response.Redirect("usr.aspx");
        }


        else
        {

        }

    }

}