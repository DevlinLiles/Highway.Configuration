using System.Linq;
using Highway.Configuration.Core.Entities;

namespace Highway.Configuration.Web.Models
{
    public class ApplicationViewModel
    {
        public ApplicationViewModel(Application application)
        {
            Name = application.Name;
            Id = application.Id;
            CountOfSettings = application.Settings.Count();
        }

        public int CountOfSettings { get; set; }

        public string Name { get; set; }

        public int Id { get; set; }
    }
}