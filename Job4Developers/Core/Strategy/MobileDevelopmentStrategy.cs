using Job4Developers.DomainObject;
using Job4Developers.Factories;

namespace Job4Developers.Core.Strategy
{
    public class MobileDevelopmentStrategy : ISpecialtyStrategy
    {
        public ServiceExecution CreateServiceExecution(Specialist specialist)
        {
            return new ServiceExecution(new MobileDevelopmentFactory(), specialist);
        }
    }
}
