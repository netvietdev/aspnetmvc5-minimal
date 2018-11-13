using log4net;
using Logging.StructuredLog4Net;
using System;
using System.Diagnostics;
using System.Web.Mvc;

namespace Rabbit.Mvc5Minimal.Controllers
{
    public class HomeController : Controller
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(HomeController));

        public ActionResult Index()
        {
            Logger.Debug("Entered at {@Time}", DateTime.Now);

            ViewBag.ListingCount = 0;

            var versionInfo = FileVersionInfo.GetVersionInfo(typeof(HomeController).Assembly.Location);

            return View(versionInfo);
        }

    }
}
