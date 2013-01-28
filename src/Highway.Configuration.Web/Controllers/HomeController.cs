using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Highway.Configuration.Core.Interfaces;
using Highway.Configuration.Web.Models;

namespace Highway.Configuration.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IApplicationService _applicationService;
        private IPrincipalService _principalService;

        public HomeController(IApplicationService applicationService, IPrincipalService principalService)
        {
            _applicationService = applicationService;
            _principalService = principalService;
        }

        public ActionResult Index()
        {
            var userName = _principalService.GetCurrentUserName();
            var applications = _applicationService.GetApplicationsByUser(userName);
            return View(new HomeIndexViewModel(applications));
        }
    }
}
