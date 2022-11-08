using Microsoft.AspNetCore.Mvc;

namespace Traveler.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
