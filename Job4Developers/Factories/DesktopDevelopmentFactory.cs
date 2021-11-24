using Job4Developers.DomainObject;
using Job4Developers.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job4Developers.Factories
{
    public class DesktopDevelopmentFactory : ServiceFactory
    {
        public override Specialist CreateSpecialist(string name, ESpecialty specialty)
        {
            return SpecialistCreator.Create(name, specialty);
        }

        public override Specialty CreateSpecialty()
        {
            return SpecialtyCreator.Create(ESpecialty.Desktop);
        }
    }
}
