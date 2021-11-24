using Job4Developers.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job4Developers.DomainObject
{
    public class MobileDevelopment : Specialty
    {
        public MobileDevelopment(ESpecialty specialtyRequired) : base(specialtyRequired)
        {
        }
    }
}
