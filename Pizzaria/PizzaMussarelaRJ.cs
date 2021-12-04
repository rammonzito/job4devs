using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public class PizzaMussarelaRJ : Pizza
    {
        public PizzaMussarelaRJ(List<string> ingredients) : base(ingredients)
        {
        }

        public override void Prepare()
        {
            Console.WriteLine($"{Ingredients.First()}");
        }
    }
}
