using Job4Developers.Enums;
using Job4Developers.Exceptions;
using System;

namespace Job4Developers.DomainObject.Strategy
{
    public class DesktopDeveloperStrategy : SpecialistStrategy
    {
        public override Specialist CreateSpecialistUsingSpecialty(string name, ESpecialty specialty)
        {
            if (IsValid(specialty))
                return new DesktopDeveloper(name, specialty);
            else
                try
                {
                    return Next.CreateSpecialistUsingSpecialty(name, specialty);
                }
                catch (Exception)
                {
                    throw new SpecialistNotFoundException();
                }
        }

        public override bool IsValid(ESpecialty specialityStrategy)
        {
            return specialityStrategy == ESpecialty.Desktop;
        }

        public override void SetNext(SpecialistStrategy strategy)
        {
            Next = strategy;
        }
    }
}
