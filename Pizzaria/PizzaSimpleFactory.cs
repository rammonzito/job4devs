using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public class PizzaSimpleFactory
    {
        public static PizzaFactoryMethod Create(ELocal local)
        {
            switch (local)
            {
                case ELocal.SP:
                    return new PizzaFactorySP();
                case ELocal.RJ:
                    return new PizzaFactoryRJ();
                default:
                    throw new ApplicationException();
            }
        }
    }
}
