using Job4Developers.DomainObject;
using Job4Developers.Enums;
using System;
using Xunit;

namespace Job4Developers.Integration.Test
{
    public class Job4DevelopersSpecialistTest
    {
        [Fact]
        public void SpecialistNonexistentShouldShowException()
        {
            Assert.Throws<ApplicationException>(() => SpecialistCreator.Create("Ramon", ESpecialty.Desktop)); 
        }
    }
}
