using Job4Developers.DomainObject;

namespace Job4Developers.Core.Strategy
{
    public interface ISpecialtyStrategy
    {
        ServiceExecution CreateServiceExecution(Specialist specialist);
    }
}
