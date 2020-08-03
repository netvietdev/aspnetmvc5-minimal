using log4net;
using Logging.StructuredLog4Net;
using Rabbit.Foundation.Configuration;
using System;
using System.Diagnostics;
using System.Web.Mvc;

namespace Rabbit.Mvc5Minimal.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;
        private static readonly ILog Logger = LogManager.GetLogger(typeof(HomeController));

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public ActionResult Index()
        {
            Logger.Debug("Entered at {@Time}", DateTime.Now);

            ViewBag.ListingCount = 0;
            ViewBag.webpagesEnabled = _configuration.Get("webpages:Enabled");

            var versionInfo = FileVersionInfo.GetVersionInfo(typeof(HomeController).Assembly.Location);

            return View(versionInfo);
        }

        public ActionResult Test(int id)
        {
            return new ContentResult()
            {
                Content = "Id is " + id
            };
        }

    }
}
