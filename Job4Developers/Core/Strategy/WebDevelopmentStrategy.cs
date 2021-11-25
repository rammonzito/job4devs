using Job4Developers.DomainObject;
using Job4Developers.Factories;

namespace Job4Developers.Core.Strategy
{
    public class WebDevelopmentStrategy : ISpecialtyStrategy
    {
        public ServiceExecution CreateServiceExecution(Specialist specialist)
        {
            return new ServiceExecution(new WebDevelopmentFactory(), specialist);
        }

        //public bool IsValid(Specialist specialty)
        //{
        //    return specialty.Specialty == Enums.ESpecialty.Web;
        //}
    }
}
