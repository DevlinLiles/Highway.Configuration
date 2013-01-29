using System;
using System.Security.Principal;
using Highway.Configuration.Core.Entities.Security;

namespace Highway.Configuration.Shared.Tests.ControllerFakes
{


    public class FakeIdentity : HighwayIdentity
    {
        private readonly string _name;

        public FakeIdentity(string userName) : base(userName)
        {
            _name = userName;

        }

        public string AuthenticationType
        {
            get { throw new System.NotImplementedException(); }
        }

        public bool IsAuthenticated
        {
            get { return !String.IsNullOrEmpty(_name); }
        }

        public string Name
        {
            get { return _name; }
        }

    }


}
