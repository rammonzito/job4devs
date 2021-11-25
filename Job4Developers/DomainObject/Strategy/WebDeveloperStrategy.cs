﻿using Job4Developers.Enums;
using Job4Developers.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job4Developers.DomainObject.Strategy
{
    public class WebDeveloperStrategy : SpecialistStrategy
    {
        public WebDeveloperStrategy()
        {
            SetNext(new DesktopDeveloperStrategy());
        }
        private new SpecialistStrategy Next { get; set; }

        public override Specialist CreateSpecialistUsingSpecialty(string name, ESpecialty specialty)
        {
            if (IsValid(specialty))
                return new WebDeveloper(name, specialty);
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
            return specialityStrategy == ESpecialty.Web;
        }

        public override void SetNext(SpecialistStrategy strategy)
        {
            Next = strategy;
        }
    }
}
