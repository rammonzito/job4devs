using System;
namespace AbstractFactory
{
    public abstract class ServicoFactory
    {
        public abstract Cliente CriarCliente(string nome, EOpcaoComida eOpcaoComida);
        public abstract Garcom CriarGarcom();
    }
}
