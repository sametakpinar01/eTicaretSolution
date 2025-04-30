using Microsoft.AspNetCore.Mvc;

namespace AdminMVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Delete()
        {
            return View();
        }
    }
}