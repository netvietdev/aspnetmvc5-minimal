using System.Web.Mvc;
using Rabbit.Mvc5Minimal.App_Start.ServicesConfiguration.Demo.Services;

namespace Rabbit.Mvc5Minimal.Controllers
{
    public class HomeController : Controller
    {
        private readonly IListingService _listingService;

        public HomeController(IListingService listingService)
        {
            _listingService = listingService;
        }

        public ActionResult Index()
        {
            ViewBag.ListingCount = _listingService.Count();

            return View();
        }

    }
}
