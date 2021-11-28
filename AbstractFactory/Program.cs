using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var clienteList = new List<Cliente>()
            {
                ClienteCreator.Create("Ramon", EOpcaoComida.Carne),
                ClienteCreator.Create("Thaina", EOpcaoComida.Vegano)
            };
            clienteList.ForEach(c => ServicoCreator.Create(c).Atender());
        }
    }
}
