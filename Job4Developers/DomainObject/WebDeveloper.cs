using Job4Developers.Enums;
using System;

namespace Job4Developers.DomainObject
{
    public class WebDeveloper : Specialist
    {
        public WebDeveloper(string name, ESpecialty specialty) : base(name, specialty)
        {
        }

        public override bool Code(Specialty specialty)
        {
            Console.WriteLine($"Web Developer Coding {specialty.GetType().Name}");
            return true;
        }
    }
}
