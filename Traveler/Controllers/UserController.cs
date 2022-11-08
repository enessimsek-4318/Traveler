using Microsoft.AspNetCore.Mvc;

namespace Traveler.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
    }
}
