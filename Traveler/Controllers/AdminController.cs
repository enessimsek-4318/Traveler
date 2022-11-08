using Microsoft.AspNetCore.Mvc;
using Traveler.Models;

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
