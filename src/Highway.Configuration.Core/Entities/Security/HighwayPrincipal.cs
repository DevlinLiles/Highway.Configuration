using System;
using System.Security.Principal;

namespace Highway.Configuration.Core.Entities.Security
{
    public class HighwayPrincipal : GenericPrincipal
    {
        public HighwayPrincipal(IIdentity identity, string[] roles) : base(identity, roles)
        {
        }

        public bool IsInRole(String roleList, Boolean allRolesRequired)
        {
            roleList = roleList.Replace(" ", "");
            string[] roles = roleList.Split(',');

            bool results = allRolesRequired;

            foreach (string role in roles)
            {
                if (allRolesRequired == false)
                {
                    results = results || base.IsInRole(role);
                    if (results == true) break;
                }
                else
                    results = results && base.IsInRole(role);

            }
            return results;
        }
    }
}