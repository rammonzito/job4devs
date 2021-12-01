using System;

namespace FactoryMethodDirty
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConn = DbFactoryCreator.Create(DataBase.SQLServer).CreateConnector("connStr").Connect();
            sqlConn.Open();
            sqlConn.ExecuteCommand("select * from usuarios");
            sqlConn.Close();
        }
    }
}
