using Job4Developers.Core.Strategy;
using Job4Developers.DomainObject;
using Job4Developers.Factories;

namespace Job4Developers.Core
{
    public class ServiceExecution
    {
        private readonly Specialty _specialty;
        private readonly Specialist _specialist;

        public ServiceExecution(ServiceFactory factory, Specialist specialist)
        {
            _specialist = factory.CreateSpecialist(specialist.Name, specialist.Specialty);
            _specialty = factory.CreateSpecialty();
        }

        public bool Perform()
        {
            return _specialist.Code(_specialty);
        }
    }
    public static class ServiceExecutionCreator
    {
        public static ServiceExecution Create(Specialist specialist, ISpecialtyStrategy strategy)
        {
            return strategy.CreateServiceExecution(specialist);
        }
    }
}
