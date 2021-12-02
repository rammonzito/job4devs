using System;

namespace Pizzaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var pizza = PizzaSimpleFactory.Criar(ELocal.RJ).Preparar(ETipo.Calabresa);
            pizza.Ingredientes.ForEach(i => Console.WriteLine(i));
        }
    }
}
