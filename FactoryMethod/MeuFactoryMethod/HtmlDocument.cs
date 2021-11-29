using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.MeuFactoryMethod
{
    public class HtmlDocument : Document
    {
        public override void MontarLayout()
        {
            Console.WriteLine("Montando no HTMl");
        }
    }
}
