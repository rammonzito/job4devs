using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public class PizzaFactorySP : PizzaFactoryMethod
    {
        public override Pizza Escolher(ETipo tipo)
        {
            switch (tipo)
            {
                case ETipo.Calabresa:
                    return new PizzaCalabresaSP(new List<string> { "calabresa", "salsinha", "tomate" });
                case ETipo.Mussarela:
                    return new PizzaMussarelaSP(new List<string> { "queijo", "tomate" });
                default:
                    throw new ApplicationException();
            }
        }
    }
}
