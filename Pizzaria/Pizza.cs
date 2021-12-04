using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public abstract class Pizza
    {
        public List<string> Ingredients { get; set; }

        public Pizza(List<string> ingredients)
        {
            Ingredients = ingredients;
        }

        public abstract void Prepare();
    }
}
