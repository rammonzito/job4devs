using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public class PizzaCalabresaRJ : Pizza
    {
        public PizzaCalabresaRJ(List<string> ingredients) : base(ingredients)
        {
        }

        public override void Prepare()
        {
            Ingredients.ForEach(i => Console.WriteLine($"Adicionando {i}"));
        }
    }
}
