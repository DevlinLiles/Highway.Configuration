using System.Security.Principal;
using Highway.Configuration.Core.Entities.Security;

namespace Highway.Configuration.Core.Interfaces
{
       public interface IPrincipalService
    {
        IPrincipal GetCurrentPrincipal();
        bool SecurityCheck(string role);
        string GetCurrentUserName();
    }
}