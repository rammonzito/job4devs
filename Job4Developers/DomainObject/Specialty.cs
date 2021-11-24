using Job4Developers.Enums;
using System;

namespace Job4Developers.DomainObject
{
    public abstract class Specialty
    {
        protected Specialty(ESpecialty specialtyRequired)
        {
            SpecialtyRequired = specialtyRequired;
        }

        public ESpecialty SpecialtyRequired { get; set; }
    }

    public static class SpecialtyCreator
    {
        public static Specialty Create(ESpecialty specialty)
        {
            switch (specialty)
            {
                case (ESpecialty.Web):
                    return new WebDevelopment(specialty);
                case (ESpecialty.Desktop):
                    return new DesktopDevelopment(specialty);
                case (ESpecialty.Mobile):
                    return new MobileDevelopment(specialty);
                default:
                    throw new ApplicationException("Specialty Not Found");
            }
        }
    }
}
