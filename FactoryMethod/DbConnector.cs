using System;
namespace FactoryMethod
{
    public abstract class DbConnector
    {
        public DbConnector(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public string ConnectionString { get; private set; }

        public abstract Connection Connect();
    }
}
