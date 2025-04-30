using Microsoft.AspNetCore.Mvc;

namespace eTicaretMVC.Controllers
{
    public class CartController : Controller
    {
        public IActionResult AddProduct()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}