using log4net;
using Logging.StructuredLog4Net;
using Rabbit.Foundation.Configuration;
using System;
using System.Diagnostics;
using System.Web.Mvc;
using Rabbit.Business;

namespace Rabbit.Mvc5Minimal.Controllers
{
    public class HomeController : Controller
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(HomeController));

        private readonly IConfiguration _configuration;
        private readonly ISimpleRunnerService _runnerService;

        public HomeController(IConfiguration configuration, ISimpleRunnerService runnerService)
        {
            _runnerService = runnerService;
            _configuration = configuration;
        }

        public ActionResult Index()
        {
            Logger.Debug("Entered at {@Time}", DateTime.Now);

            var msg = _runnerService.Run();

            ViewBag.ServiceMessage = msg;
            ViewBag.webpagesEnabled = _configuration.Get("webpages:Enabled");
            ViewBag.BuildDate = Properties.Resources.BuildDate;

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
