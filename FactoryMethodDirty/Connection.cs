using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDirty
{
    public class Connection
    {
        public string ConnnectionString { get; set; }
        public bool Opened { get; set; }

        public void ExecuteCommand(string command)
        {
            Console.WriteLine($"Executando o comando {command}");
        }

        public void Open()
        {
            Opened = true;
        }

        public void Close()
        {
            Opened = false;
        }
    }
}
