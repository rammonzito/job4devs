using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job4Developers
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
                default:
                    throw new ApplicationException("Specialty Not Found");
            }
        }
    }
}
