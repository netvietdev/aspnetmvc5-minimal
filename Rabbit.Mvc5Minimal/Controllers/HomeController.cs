using Rabbit.Mvc5Minimal.Models.Demo.Services;
using System.Web.Mvc;

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
