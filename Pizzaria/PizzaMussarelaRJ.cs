using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public class PizzaMussarelaRJ : Pizza
    {
        public PizzaMussarelaRJ(List<string> ingredientes) : base(ingredientes)
        {
        }

        public override void Preparar()
        {
            Console.WriteLine($"{Ingredientes.First()}");
        }
    }
}
