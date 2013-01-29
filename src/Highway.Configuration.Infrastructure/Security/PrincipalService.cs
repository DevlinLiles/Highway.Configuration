using System;
using System.Linq;
using System.Security.Principal;
using Highway.Configuration.Core.Entities.Security;
using Highway.Configuration.Core.Interfaces;

namespace Highway.Configuration.Infrastructure.Security
{
    public class PrincipalService : IPrincipalService
    {
        public IPrincipal GetCurrentPrincipal()
        {
            return System.Threading.Thread.CurrentPrincipal as IPrincipal;
        }

        public bool SecurityCheck(string role)
        {
            var roleList = role.Replace(" ", "");
            var roles = roleList.Split(',');

            var principal = GetCurrentPrincipal();
            return principal != null && roles.Any(principal.IsInRole);
        }

        public string GetCurrentUserName()
        {
            var principal = GetCurrentPrincipal();
            return ((HighwayIdentity)principal.Identity).Name;
        }
    }
}