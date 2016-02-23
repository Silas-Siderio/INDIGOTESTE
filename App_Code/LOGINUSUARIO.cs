using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;


/// <summary>
/// Summary description for LOGINUSUARIO
/// </summary>
public class LOGINUSUARIO
{

    public int idtipo { get; set; }
    public string login { get; set; }
    public string senha { get; set; }

    public DataTable VERIFICAUSUARIO(string login , string senha)
    {
            DAL lista = new DAL();
            DataTable dt = new DataTable();
            dt = lista.LISTA_LOGIN(login,senha);
            return dt;
        }
    }