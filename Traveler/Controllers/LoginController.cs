using BLL.Abstract;
using Microsoft.AspNetCore.Mvc;
using Traveler.Entity;
using Traveler.Models;

namespace Traveler.Controllers
{
    public class LoginController : Controller
    {
        private IUserService _userService;

        public LoginController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult LoginCheck()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LoginCheck(LoginModel entity)
        {
            var user = _userService.Find(i => i.email == entity.email);
            if (user == null)
            {

            }
            else
            {
                if (entity.password == user.password)
                {
                    return View("Home/Index");
                }
            }
            return View();
        }
    }
}
