using Job4Developers.DomainObject;
using Job4Developers.Enums;

namespace Job4Developers.Factories
{
    public abstract class ServiceFactory
    {
        public abstract Specialist CreateSpecialist(string name, ESpecialty specialty);
        public abstract Specialty CreateSpecialty();
    }
}
