namespace AbstractFactory
{
    internal class ClienteCarne : Cliente
    {
        public ClienteCarne(string nome, EOpcaoComida opcao) : base(nome, opcao)
        {
        }
    }
}