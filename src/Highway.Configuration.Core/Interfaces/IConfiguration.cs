using System;
using System.ServiceModel;
using Highway.Configuration.Core.Entities;

namespace Highway.Configuration.Core.Interfaces
{
    [ServiceContract]
    public interface IConfiguration
    {
        [OperationContract]
        Application GetApplication(Guid applicationId);

        [OperationContract]
        void UpdateSetting(Guid applicationId, ApplicationSetting update);

        [OperationContract]
        Application AddApplication(Application application);

        [OperationContract]
        ApplicationSetting AddSetting(Guid applicationId, ApplicationSetting setting);
    }
}
