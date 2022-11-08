using Microsoft.AspNetCore.Mvc;

namespace Traveler.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
