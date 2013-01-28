using System.Collections.Generic;
using Highway.Configuration.Core.Entities;

namespace Highway.Configuration.Core.Interfaces
{
    public interface IApplicationService
    {
        IEnumerable<Application> GetApplicationsByUser(string userName);
    }
}