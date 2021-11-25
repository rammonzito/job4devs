﻿using Job4Developers.Core;
using Job4Developers.Core.Strategy;
using Job4Developers.DomainObject;
using Job4Developers.Enums;
using System;
using System.Collections.Generic;

namespace Job4Developers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Devs!");


            Specialist Ramon = SpecialistCreator.Create("Ramon", ESpecialty.Web);
            Specialist Joao = SpecialistCreator.Create("João", ESpecialty.Desktop);

            ServiceExecutionCreator.Create(Ramon, new WebDevelopmentStrategy()).Perform();
            ServiceExecutionCreator.Create(Joao, new DesktopDevelopmentStrategy()).Perform();
        }
    }
}
