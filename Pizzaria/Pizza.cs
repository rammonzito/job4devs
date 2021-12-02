using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public abstract class Pizza
    {
        public string Sabor { get; set; }
        public abstract void Cozinhar();
    }

    public static class PizzaCreator
    {
        public static Pizza Create(ETipoPizza tipo)
        {
            switch (tipo)
            {
                case ETipoPizza.Calabresa:
                    return new PizzaCalabresa();
                case ETipoPizza.Muzzarela:
                    return new PizzaMuzzarela();
                default:
                    throw new ApplicationException();
            }
        }
    }
}
