using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.MeuFactoryMethod
{
    public class PdfDocument : Document
    {
        public override void MontarLayout()
        {
            Console.WriteLine("Montando aqui o meu Layout do jeito que eu quero no PDF");
        }
    }
}
