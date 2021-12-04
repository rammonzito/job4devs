using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public abstract class PizzaFactoryMethod
    {
        public abstract Pizza Choose(EPizzaType type);
    }
}
