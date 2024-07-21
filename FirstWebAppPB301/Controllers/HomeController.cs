using Microsoft.AspNetCore.Mvc;

namespace FirstWebAppPB301.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return File("~/img/Road_in_Norway.jpg","image/jpg");
            //return Json(new Product
            //{
            //Id = 1,
            //Name = "Test",
            //});
            ViewData["name"] = "Emil";
            ViewBag.age = 27;
            TempData["address"] = "Baki";
            //return View();
            return RedirectToAction(nameof(About));
        }
        public IActionResult About()
        {
            //return Content("First WebApp of About");
            return View();
        }
        public IActionResult Contact()
        {
            //return View();
            return RedirectToAction(nameof(About));
        }
    }
}
