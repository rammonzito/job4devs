using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public class PizzaFactoryRJ : PizzaFactoryMethod
    {
        public override Pizza Escolher(ETipo tipo)
        {
            switch (tipo)
            {
                case ETipo.Calabresa:
                    return new PizzaCalabresaRJ(new List<string> { "calabresa", "cebola" });
                case ETipo.Mussarela:
                    return new PizzaMussarelaRJ(new List<string> { "queijo minas", "salsinha" });
                default:
                    throw new ApplicationException();
            }
        }
    }
}
