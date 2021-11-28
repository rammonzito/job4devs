using System;
namespace AbstractFactory
{
    public abstract class Cliente
    {
        public string Nome { get; set; }
        public EOpcaoComida Opcao { get; set; }

        public Cliente(string nome, EOpcaoComida opcao)
        {
            Nome = nome;
            Opcao = opcao;
        }
    }
    public static class ClienteCreator
    {
        public static Cliente Create(string nome, EOpcaoComida opcaoComida)
        {
            switch (opcaoComida)
            {
                case (EOpcaoComida.Carne):
                    return new ClienteCarne(nome, opcaoComida);
                case (EOpcaoComida.Vegano):
                    return new ClienteVegano(nome, opcaoComida);
                default:
                    throw new ApplicationException("Tipo de Cliente não Localizado");
            }
        }
    }
}
