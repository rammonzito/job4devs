using System;
namespace FactoryMethod
{
    public class ExecucaoFactoryMethod
    {
        public static void Executar()
        {
            var sqlCon = DbFactory.Database(EDataBase.Sql).CreateConnector("MyconnectionString").Connect();
            sqlCon.ExecuteCommand("Select * From Usuarios");
            sqlCon.Close();
        }
    }
}
