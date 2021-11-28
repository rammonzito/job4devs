using System;
namespace FactoryMethod
{
    public abstract class DbFactory
    {
        public abstract DbConnector CreateConnector(string connectionString);
        public static DbFactory Database(EDataBase dataBase)
        {
            switch (dataBase)
            {
                case (EDataBase.Sql):
                    return new SqlFactory();
                case (EDataBase.Oracle):
                    return new OracleFactory();
                default:
                    throw new ApplicationException("Tipo de Conexão não localizada");
            }
        }
    }
}
