using Highway.Configuration.Core.Entities.Security;

namespace Highway.Configuration.Core.Interfaces
{
       public interface IPrincipalService
    {
        HighwayPrincipal GetCurrentPrincipal();
        bool SecurityCheck(string role);
        string GetCurrentUserName();
    }
}