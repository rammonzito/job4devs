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

            Layout html = new HtmlDocument().MontarLayout();
            
        }
    }
}
