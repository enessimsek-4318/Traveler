using BLL.Abstract;
using Microsoft.AspNetCore.Mvc;
using Traveler.Entity;
using Traveler.Models;

namespace Traveler.Controllers
{
    public class HomeController : Controller
    {
        IPostService _postService;
        public HomeController(IPostService postService)
        {
            _postService = postService;
        }

        public IActionResult Index()
        {
            return View(new PostListModel()
            {
                posts=_postService.GetAll()
            });
        }
    }
}
