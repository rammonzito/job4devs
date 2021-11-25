using Job4Developers.DomainObject;
using Job4Developers.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job4Developers.Core.Strategy
{
    public class DesktopDevelopmentStrategy : ISpecialtyStrategy
    {
        public ServiceExecution CreateServiceExecution(Specialist specialist)
        {
            return new ServiceExecution(new DesktopDevelopmentFactory(), specialist);
        }

        //public bool IsValid(Specialist specialty)
        //{
        //    return specialty.Specialty == Enums.ESpecialty.Desktop;
        //}
    }
}
