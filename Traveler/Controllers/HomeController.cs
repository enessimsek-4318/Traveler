using BLL.Abstract;
using Microsoft.AspNetCore.Mvc;
using Traveler.Entity;

namespace Traveler.Controllers
{
    public class HomeController : Controller
    {
        IAdminService _adminService;
        public HomeController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
