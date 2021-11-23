using Job4Developers.Core;
using Job4Developers.DomainObject;
using Job4Developers.Enums;
using System;

namespace Job4Developers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var specialist = SpecialistCreator.Create("Ramon", ESpecialty.Web);
            ServiceExecutionCreator.Create(specialist).Perform();
        }
    }
}
