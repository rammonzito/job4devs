using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public class PizzaCalabresaSP : Pizza
    {
        public PizzaCalabresaSP(List<string> ingredients) : base(ingredients)
        {
        }

        public override void Prepare()
        {
            Console.WriteLine($"Misturando tudo");
            Ingredients.ForEach(i => Console.WriteLine(i));
        }
    }
}
