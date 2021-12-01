using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDirty
{
    public abstract class DbConnector
    {
        public abstract Connection Connect();
        public string ConnectionString { get; set; }

        public DbConnector(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}
