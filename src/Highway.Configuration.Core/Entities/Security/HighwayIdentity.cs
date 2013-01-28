using System;
using System.Security.Principal;

namespace Highway.Configuration.Core.Entities.Security
{
    public class HighwayIdentity : GenericIdentity
    {
        public HighwayIdentity(string name) : base(name)
        {
        }

        public HighwayIdentity(string name, string type) : base(name, type)
        {
        }

        public Guid UserId { get; set; }

        public string Username { get; set; }
    }
}