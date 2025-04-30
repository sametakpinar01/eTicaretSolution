using Microsoft.AspNetCore.Mvc;

namespace eTicaretMVC.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            return View();
        }
    }
}