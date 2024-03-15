using Microsoft.AspNetCore.Mvc;

namespace CoreMVCDevam_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CarpimTablosu()
        {
            return View();
        }
    }
}
