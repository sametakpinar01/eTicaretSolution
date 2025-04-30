using Microsoft.AspNetCore.Mvc;

namespace eTicaretMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Listing()
        {
            return View();
        }

        public IActionResult ProductDetail(string categoryName, string title, int id)
        {
            return View();
        }
    }
}