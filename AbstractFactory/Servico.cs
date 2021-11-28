using System;
namespace AbstractFactory
{
    public class Servico
    {
        private readonly Cliente _cliente;
        private readonly Garcom _garcom;

        public Servico(ServicoFactory factory, Cliente cliente)
        {
            _cliente = factory.CriarCliente(cliente.Nome, cliente.Opcao);
            _garcom = factory.CriarGarcom();
        }

        public void Atender()
        {
            _garcom.Servir(_cliente);
        }
    }

    public static class ServicoCreator
    {
        public static Servico Create(Cliente cliente)
        {
            switch (cliente.Opcao)
            {
                case (EOpcaoComida.Vegano):
                    return new Servico(new ServicoVeganoFactory(), cliente);
                case (EOpcaoComida.Carne):
                    return new Servico(new ServicoCarneFactory(), cliente);
                default:
                    throw new ApplicationException("Serviço Não Localizado");
            }
        }
    }
}
