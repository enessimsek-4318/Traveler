using Microsoft.AspNetCore.Mvc;
using Traveler.Entity;

namespace Traveler.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Admin model)
        {
            return View();
        }
    }
}
