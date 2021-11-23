using Job4Developers.DomainObject;
using Job4Developers.Enums;
using Job4Developers.Factories;
using System;

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
        public static ServiceExecution Create(Specialist specialist)
        {
            switch (specialist.Specialty)
            {
                case ESpecialty.Web:
                    return new ServiceExecution(new WebDevelopmentFactory(), specialist);
                case ESpecialty.Desktop:
                    return new ServiceExecution(new DesktopDeveloperFactory(), specialist);
                //case ESpecialty.Mobile:
                //    break;
                default:
                    throw new ApplicationException("Service Not Found");
            }
        }
    }
}
