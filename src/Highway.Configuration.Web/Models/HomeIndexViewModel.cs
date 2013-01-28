using System.Collections.Generic;
using System.Linq;
using Highway.Configuration.Core.Entities;

namespace Highway.Configuration.Web.Models
{
    public class HomeIndexViewModel
    {
        public HomeIndexViewModel(IEnumerable<Application> applications)
        {
            Applications = applications.Select(x => new ApplicationViewModel(x));
        }

        public IEnumerable<ApplicationViewModel> Applications { get; set; }
    }
}