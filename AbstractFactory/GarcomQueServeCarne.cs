using System;

namespace AbstractFactory
{
    internal class GarcomQueServeCarne : Garcom
    {
        public GarcomQueServeCarne(EOpcaoComida opcaoComida) : base(opcaoComida)
        {
        }

        public override void Servir(Cliente cliente)
        {
            Console.WriteLine($"Garçom que serve carne sequindo um cliente {cliente.GetType().Name}");
        }
    }
}