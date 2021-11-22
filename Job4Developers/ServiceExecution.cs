using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job4Developers
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

        public void Perform()
        {
            _specialist.Code(_specialty);
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
                //case ESpecialty.Desktop:
                //    break;
                //case ESpecialty.Mobile:
                //    break;
                default:
                    throw new ApplicationException("Service Not Found");
            }
        }
    }
}
