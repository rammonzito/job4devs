using Job4Developers.DomainObject;
using Job4Developers.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job4Developers.Factories
{
    public abstract class ServiceFactory
    {
        public abstract Specialist CreateSpecialist(string name, ESpecialty specialty);
        public abstract Specialty CreateSpecialty();
    }
}
