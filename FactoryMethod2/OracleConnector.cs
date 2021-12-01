using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod2
{
    public class OracleConnector : DbConnector
    {
        public OracleConnector(string connectionString) : base(connectionString)
        {
        }

        public override Connection Connect()
        {
            throw new NotImplementedException();
        }
    }
}
