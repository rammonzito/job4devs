using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod2
{
    public class Connection
    {
        public string ConnectionString { get; set; }

        public Connection(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public bool Opened { get; set; }

        public void ExecuteCommand(string command)
        {
            Console.WriteLine($"Executando o comando {command}");
        }
        public void Open()
        {
            Opened = true;
            Console.WriteLine("Conexão Aberta");
        }

        public void Close()
        {
            Opened = false;
            Console.WriteLine("Conexão Fechada");
        }

    }
}
