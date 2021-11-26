using Job4Developers.Enums;
using Job4Developers.Exceptions;
using Microsoft.Extensions.Logging;
using System;

namespace Job4Developers.DomainObject.Strategy
{
    public class WebDeveloperStrategy : SpecialistStrategy
    {
        // private readonly ILogger<WebDeveloperStrategy> _logger;

        public WebDeveloperStrategy(/*ILogger<WebDeveloperStrategy> logger*/)
        {
            // _logger = logger;
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
                catch (Exception ex)
                {
                    // _logger.LogInformation(ex.InnerException.Message);
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
