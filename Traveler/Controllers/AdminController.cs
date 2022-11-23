using BLL.Abstract;
using Microsoft.AspNetCore.Mvc;
using Traveler.Entity;

namespace Traveler.Controllers
{
    public class AdminController : Controller
    {
        private IAdminService _adminService;
        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }
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
