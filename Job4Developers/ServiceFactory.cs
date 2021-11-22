using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job4Developers
{
    public abstract class ServiceFactory
    {
        public abstract Specialist CreateSpecialist(string name, ESpecialty specialty);
        public abstract Specialty CreateSpecialty();
    }
}
