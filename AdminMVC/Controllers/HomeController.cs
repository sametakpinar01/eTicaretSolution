using Microsoft.AspNetCore.Mvc;

namespace AdminMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}