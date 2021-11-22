using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job4Developers
{
    public class WebDeveloper : Specialist
    {
        public WebDeveloper(string name, ESpecialty specialty) : base(name, specialty)
        {
        }

        public override void Code(Specialty specialty)
        {
            Console.WriteLine($"Web Developer Coding {specialty.GetType().Name}");
        }
    }
}
