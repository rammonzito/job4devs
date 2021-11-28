using System;
namespace FactoryMethod
{
    public class SqlConnector : DbConnector
    {
        public SqlConnector(string connectionString) : base(connectionString)
        {
        }

        public override Connection Connect()
        {
            Console.WriteLine("Conextando ao banco Sql Server");
            var connection = new Connection(ConnectionString);
            return connection;
        }
    }
}
