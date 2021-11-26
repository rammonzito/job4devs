using Job4Developers.DomainObject;
using Job4Developers.Factories;

namespace Job4Developers.Core.Strategy
{
    public class DesktopDevelopmentStrategy : ISpecialtyStrategy
    {
        public ServiceExecution CreateServiceExecution(Specialist specialist)
        {
            return new ServiceExecution(new DesktopDevelopmentFactory(), specialist);
        }
    }
}
