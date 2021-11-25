using Job4Developers.DomainObject.Strategy;
using Job4Developers.Enums;
using System;

namespace Job4Developers.DomainObject
{
    public abstract class Specialist
    {
        protected Specialist(string name, ESpecialty specialty)
        {
            Name = name;
            Specialty = specialty;
        }

        public string Name { get; set; }
        public ESpecialty Specialty { get; set; }

        public abstract bool Code(Specialty specialty);
    }
    public static class SpecialistCreator
    {
        public static Specialist Create(string name, ESpecialty specialty)
        {
            SpecialistStrategy strategy = new WebDeveloperStrategy();
            strategy.SetNext(new DesktopDeveloperStrategy());

            return SpecialistStrategy.ProcessRequest(name, specialty, strategy);
        }
    }
}
