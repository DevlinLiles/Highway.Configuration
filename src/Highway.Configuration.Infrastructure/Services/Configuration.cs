using System;
using Highway.Configuration.Core.Entities;
using Highway.Configuration.Core.Interfaces;

namespace Highway.Configuration.Infrastructure.Services
{
    public class Configuration : IConfiguration
    {
        public Application GetApplication(Guid applicationId)
        {
            throw new NotImplementedException();
        }

        public void UpdateSetting(Guid applicationId, ApplicationSetting update)
        {
            throw new NotImplementedException();
        }

        public Application AddApplication(Application application)
        {
            throw new NotImplementedException();
        }

        public ApplicationSetting AddSetting(Guid applicationId, ApplicationSetting setting)
        {
            throw new NotImplementedException();
        }
    }
}