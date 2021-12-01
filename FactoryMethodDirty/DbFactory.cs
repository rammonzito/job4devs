using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDirty
{
    public abstract class DbFactory
    {
        public abstract DbConnector CreateConnector(string connectionString);
    }

    public static class DbFactoryCreator
    {
        public static DbFactory Create(DataBase database)
        {
            switch (database)
            {
                case DataBase.SQLServer:
                    return new SqlServerFactory();
                default:
                    throw new ApplicationException();
            }
        }
    }
}
