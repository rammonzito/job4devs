using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public class PizzaFactoryRJ : PizzaFactoryMethod
    {
        public override Pizza Choose(EPizzaType pizzaType)
        {
            switch (pizzaType)
            {
                case EPizzaType.Calabresa:
                    return new PizzaCalabresaRJ(new List<string> { "calabresa", "cebola" });
                case EPizzaType.Mussarela:
                    return new PizzaMussarelaRJ(new List<string> { "queijo minas", "salsinha" });
                default:
                    throw new ApplicationException();
            }
        }
    }
}
