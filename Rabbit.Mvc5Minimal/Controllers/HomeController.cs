using log4net;
using Rabbit.SimpleInjectorDemo.Services;
using System;
using System.Diagnostics;
using System.Web.Mvc;

namespace Rabbit.Mvc5Minimal.Controllers
{
    public class HomeController : Controller
    {
        private readonly IListingService _listingService;
        private static readonly ILog Logger = LogManager.GetLogger(typeof(HomeController));

        public HomeController(IListingService listingService)
        {
            _listingService = listingService;
        }

        public ActionResult Index()
        {
            Logger.DebugFormat("Entered at {0}", DateTime.Now);

            ViewBag.ListingCount = _listingService.Count();

            var versionInfo = FileVersionInfo.GetVersionInfo(typeof(HomeController).Assembly.Location);

            return View(versionInfo);
        }

    }
}
