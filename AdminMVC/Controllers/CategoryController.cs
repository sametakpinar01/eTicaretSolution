using Microsoft.AspNetCore.Mvc;

namespace AdminMVC.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}