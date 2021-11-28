namespace AbstractFactory
{
    internal class ClienteVegano : Cliente
    {
        public ClienteVegano(string nome, EOpcaoComida opcao) : base(nome, opcao)
        {
        }
    }
}