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
