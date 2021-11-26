using Job4Developers.Core;
using Job4Developers.Core.Strategy;
using Job4Developers.DomainObject;
using Job4Developers.Enums;
using Xunit;

namespace Job4Developers.Integration.Test
{
    public class Job4DevelopersServiceExecutionTest
    {
        [Fact]
        public void ValidServiceExecutionShouldWorks()
        {
            var specialist = SpecialistCreator.Create("Ramon", ESpecialty.Desktop);
            Assert.True(ServiceExecutionCreator.Create(specialist, new DesktopDevelopmentStrategy()).Perform());
        }
    }
}
