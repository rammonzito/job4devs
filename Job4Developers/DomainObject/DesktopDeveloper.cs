using Job4Developers.Enums;
using System;

namespace Job4Developers.DomainObject
{
    public class DesktopDeveloper : Specialist
    {
        public DesktopDeveloper(string name, ESpecialty specialty) : base(name, specialty)
        {
        }

        public override bool Code(Specialty specialty)
        {
            Console.WriteLine($"Desktop Developer Coding {specialty.GetType().Name}");
            return true;
        }
    }
}
