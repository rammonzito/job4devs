using Job4Developers.Core;
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

            var specialists = new List<Specialist>
            {
                SpecialistCreator.Create("Ramon", ESpecialty.Web),
                SpecialistCreator.Create("João", ESpecialty.Desktop)
            };

            specialists.ForEach(s => ServiceExecutionCreator.Create(s).Perform());
        }
    }
}
