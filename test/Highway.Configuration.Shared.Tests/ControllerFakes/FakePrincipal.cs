using System.Linq;
using System.Security.Principal;
using Highway.Configuration.Core.Entities.Security;

namespace Highway.Configuration.Shared.Tests.ControllerFakes
{

    public class FakePrincipal : HighwayPrincipal
    {
        private readonly IIdentity _identity;
        private readonly string[] _roles;

        public FakePrincipal(IIdentity identity, string[] roles) : base(identity, roles)
        {
            _identity = identity;
            _roles = roles;
        }

        public IIdentity Identity
        {
            get { return _identity; }
        }

        public bool IsInRole(string role)
        {
            if (_roles == null)
                return false;
            return _roles.Contains(role);
        }
    }



}
