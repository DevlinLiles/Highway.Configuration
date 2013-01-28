using System.Collections.Generic;

namespace Highway.Configuration.Core.Entities
{
    public class Application
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<ApplicationSetting> Settings { get; set; }
    }
}
