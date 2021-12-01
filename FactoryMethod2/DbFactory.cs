using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod2
{
    public abstract class DbFactory
    {
        public abstract DbConnector CreateConnector(string connectionString);

        public static DbFactory Database(DataBase database)
        {
            switch (database)
            {
                case DataBase.sql:
                    return new SqlServerFactory();
                case DataBase.oracle:
                    return new OracleFactory();
                default:
                    throw new ApplicationException();
            }
        }

    }
}
