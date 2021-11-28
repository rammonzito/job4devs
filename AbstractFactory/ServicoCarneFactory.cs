using System;
namespace AbstractFactory
{
    public class ServicoCarneFactory : ServicoFactory
    {
        public override Cliente CriarCliente(string nome, EOpcaoComida eOpcaoComida)
        {
            return ClienteCreator.Create(nome, eOpcaoComida);
        }

        public override Garcom CriarGarcom()
        {
            return GarcomCreator.Create(EOpcaoComida.Carne);
        }
    }
}
