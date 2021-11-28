using System;

namespace AbstractFactory
{
    internal class GarcomQueServeVegano : Garcom
    {
        public GarcomQueServeVegano(EOpcaoComida opcaoComida) : base(opcaoComida)
        {
        }

        public override void Servir(Cliente cliente)
        {
            Console.WriteLine($"Garçom que serve vegano sequindo um cliente {cliente.GetType().Name}");
        }
    }
}