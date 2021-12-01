namespace FactoryMethod2
{
    internal class OracleFactory : DbFactory
    {
        public override DbConnector CreateConnector(string connectionString)
        {
            return new OracleConnector(connectionString);
        }
    }
}