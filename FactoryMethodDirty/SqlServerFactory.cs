using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDirty
{
    public class SqlServerFactory : DbFactory
    {
        public override DbConnector CreateConnector(string connectionString)
        {
            return new SqlServerConnector(connectionString);
        }
    }
}
