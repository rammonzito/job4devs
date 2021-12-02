using System;

namespace Pizzaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var pizza = PizzaSimpleFactory.Criar(ELocal.RJ).Escolher(ETipo.Mussarela);
            pizza.Preparar();
        }
    }
}
