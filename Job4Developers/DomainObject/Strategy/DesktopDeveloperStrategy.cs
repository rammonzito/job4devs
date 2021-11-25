﻿using Job4Developers.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job4Developers.DomainObject.Strategy
{
    public class DesktopDeveloperStrategy : SpecialistStrategy
    {
        public override Specialist CreateSpecialistUsingSpecialty(string name, ESpecialty specialty)
        {
            if (IsValid(specialty))
                return new DesktopDeveloper(name, specialty);
            else
                return Next?.CreateSpecialistUsingSpecialty(name, specialty);

            throw new ApplicationException("Specialist Not Found");
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