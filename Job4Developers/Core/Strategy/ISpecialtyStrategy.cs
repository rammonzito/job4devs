using Job4Developers.DomainObject;
using Job4Developers.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job4Developers.Core.Strategy
{
    public interface ISpecialtyStrategy
    {
        //bool IsValid(Specialist specialty);
        ServiceExecution CreateServiceExecution(Specialist specialist);
    }
}
