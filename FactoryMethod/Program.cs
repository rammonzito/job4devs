using FactoryMethod.MeuFactoryMethod;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //ExecucaoFactoryMethod.Executar();

            Document html = new HtmlDocument();
            html.MontarLayout();
        }
    }
}
