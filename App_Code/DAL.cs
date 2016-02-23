using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;

/// <summary>
/// Summary description for DAL
/// </summary>
public class DAL
{

    public DataTable LISTA_MENUADMIN()
    {
        DatabaseProviderFactory factory = new DatabaseProviderFactory();
        Database BANCO = factory.Create("INDIGO");
        System.Data.Common.DbCommand cmd = BANCO.GetStoredProcCommand("lista_menuusuarioadmin");

        DataTable LISTANPROC = BANCO.ExecuteDataSet(cmd).Tables[0];
        return LISTANPROC;
    }

    public DataTable LISTA_MENUUSER()
    {
        DatabaseProviderFactory factory = new DatabaseProviderFactory();
        Database BANCO = factory.Create("INDIGO");
        System.Data.Common.DbCommand cmd = BANCO.GetStoredProcCommand("lista_menuusuario");

        DataTable LISTANPROC = BANCO.ExecuteDataSet(cmd).Tables[0];
        return LISTANPROC;

    }

    public DataTable LISTA_LOGIN(string usuario, string senha)
    {
        DatabaseProviderFactory factory = new DatabaseProviderFactory();
        Database BANCO = factory.Create("IND");
        System.Data.Common.DbCommand cmd = BANCO.GetStoredProcCommand("lista_usuario");
        BANCO.AddInParameter(cmd, "@login", DbType.String, usuario);
        BANCO.AddInParameter(cmd, "@senha", DbType.String, senha);

        DataTable LISTANPROC = BANCO.ExecuteDataSet(cmd).Tables[0];
        return LISTANPROC;

    }


}
