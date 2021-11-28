using System;
namespace AbstractFactory
{
    public abstract class Garcom
    {
        public EOpcaoComida OpcaoComida { get; set; }

        public Garcom(EOpcaoComida opcaoComida)
        {
            OpcaoComida = opcaoComida;
        }
        public abstract void Servir(Cliente cliente);
    }
    public static class GarcomCreator
    {
        public static Garcom Create(EOpcaoComida opcaoComida)
        {
            switch (opcaoComida)
            {
                case (EOpcaoComida.Carne):
                    return new GarcomQueServeCarne(opcaoComida);
                case (EOpcaoComida.Vegano):
                    return new GarcomQueServeVegano(opcaoComida);
                default:
                    throw new ApplicationException("Tipo de Carcom não localizado");
            }
        }
    }
}
