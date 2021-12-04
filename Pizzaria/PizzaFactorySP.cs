using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public class PizzaFactorySP : PizzaFactoryMethod
    {
        public override Pizza Choose(EPizzaType pizzaType)
        {
            switch (pizzaType)
            {
                case EPizzaType.Calabresa:
                    return new PizzaCalabresaSP(new List<string> { "calabresa", "salsinha", "tomate" });
                case EPizzaType.Mussarela:
                    return new PizzaMussarelaSP(new List<string> { "queijo", "tomate" });
                default:
                    throw new ApplicationException();
            }
        }
    }
}
