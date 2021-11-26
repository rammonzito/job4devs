using Job4Developers.DomainObject;
using Job4Developers.Enums;
using Job4Developers.Exceptions;
using Xunit;

namespace Job4Developers.Integration.Test
{
    public class Job4DevelopersSpecialistTest
    {
        [Fact]
        public void SpecialistNonexistentShouldShowException()
        {
            Assert.Throws<SpecialistNotFoundException>(() => SpecialistCreator.Create("Ramon", ESpecialty.IoT)); 
        }

        [Fact]
        public void SpecialistExistentShouldWorks()
        {
            var specialist = SpecialistCreator.Create("Ramon", ESpecialty.Web);
            Assert.NotNull(specialist);
        }
    }
}
