using Job4Developers.DomainObject;
using Job4Developers.Enums;

namespace Job4Developers.Factories
{
    public class DesktopDevelopmentFactory : ServiceFactory
    {
        public override Specialist CreateSpecialist(string name, ESpecialty specialty)
        {
            return SpecialistCreator.Create(name, specialty);
        }

        public override Specialty CreateSpecialty()
        {
            return SpecialtyCreator.Create(ESpecialty.Desktop);
        }
    }
}
