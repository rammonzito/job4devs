using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job4Developers
{
    public class WebDevelopmentFactory : ServiceFactory
    {
        public override Specialist CreateSpecialist(string name, ESpecialty specialty)
        {
            return SpecialistCreator.Create(name, specialty);
        }

        public override Specialty CreateSpecialty()
        {
            return SpecialtyCreator.Create(ESpecialty.Web);
        }
    }
}
