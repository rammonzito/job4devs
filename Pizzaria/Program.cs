using System;

namespace Pizzaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var pizza = PizzaSimpleFactory.Create(ELocal.RJ).Choose(EPizzaType.Mussarela);
            pizza.Prepare();
        }
    }
}
