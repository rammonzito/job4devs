using System;
namespace FactoryMethod
{
    public class OracleConnector : DbConnector
    {
        public OracleConnector(string connectionString) : base(connectionString)
        {
        }

        public override Connection Connect()
        {
            Console.WriteLine("Conectando ao banco Oracle");
            return new Connection(ConnectionString);
        }
    }
}
