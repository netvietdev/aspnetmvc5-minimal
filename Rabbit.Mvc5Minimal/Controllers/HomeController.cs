using System.Web.Mvc;

namespace Rabbit.Mvc5Minimal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

    }
}
