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

        public abstract void Code(Specialty specialty);
    }
    public static class SpecialistCreator
    {
        public static Specialist Create(string name, ESpecialty specialty)
        {
            switch (specialty)
            {
                case ESpecialty.Web:
                    return new WebDeveloper(name, specialty);
                //case ESpecialty.Desktop:
                //    break;
                //case ESpecialty.Mobile:
                //    break;
                default:
                    throw new ApplicationException("Specialist Not Found");
            }
        }
    }
}
