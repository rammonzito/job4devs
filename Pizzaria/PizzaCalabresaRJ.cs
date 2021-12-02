using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public class PizzaCalabresaRJ : Pizza
    {
        public PizzaCalabresaRJ(List<string> ingredientes) : base(ingredientes)
        {
        }

        public override void Preparar()
        {
            Ingredientes.ForEach(i => Console.WriteLine($"Adicionando {i}"));
        }
    }
}
