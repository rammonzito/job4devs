using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public abstract class Pizza
    {
        public List<string> Ingredientes { get; set; }

        public Pizza(List<string> ingredientes)
        {
            Ingredientes = ingredientes;
        }
    }
}
