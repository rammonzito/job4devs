using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public class PizzaCalabresaSP : Pizza
    {
        public PizzaCalabresaSP(List<string> ingredientes) : base(ingredientes)
        {
        }

        public override void Preparar()
        {
            Console.WriteLine($"Misturando tudo");
            Ingredientes.ForEach(i => Console.WriteLine(i));
        }
    }
}
