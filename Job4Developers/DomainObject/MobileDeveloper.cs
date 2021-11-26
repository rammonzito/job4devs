using Job4Developers.Enums;
using System;

namespace Job4Developers.DomainObject
{
    public class MobileDeveloper : Specialist
    {
        public MobileDeveloper(string name, ESpecialty specialty) : base(name, specialty)
        {
        }

        public override bool Code(Specialty specialty)
        {
            Console.WriteLine($"Mobile Developer Coding {specialty.GetType().Name}");
            return true;
        }
    }
}
