using Job4Developers.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job4Developers.DomainObject.Strategy
{
    public abstract class SpecialistStrategy
    {
        protected SpecialistStrategy Next;
        public abstract void SetNext(SpecialistStrategy strategy);
        public abstract Specialist CreateSpecialistUsingSpecialty(string name, ESpecialty specialty);
        public abstract bool IsValid(ESpecialty specialityStrategy);
        public static Specialist ProcessRequest(string name, ESpecialty specialty, SpecialistStrategy strategy)
        {
            return strategy.CreateSpecialistUsingSpecialty(name, specialty);
        }
    }
}
