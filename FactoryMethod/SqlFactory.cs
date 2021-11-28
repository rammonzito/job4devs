namespace FactoryMethod
{
    internal class SqlFactory : DbFactory
    {
        public override DbConnector CreateConnector(string connectionString)
        {
            return new SqlConnector(connectionString);
        }
    }
}