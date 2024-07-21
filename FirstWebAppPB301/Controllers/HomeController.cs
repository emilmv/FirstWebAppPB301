using FirstWebAppPB301.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebAppPB301.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return File("~/img/Road_in_Norway.jpg","image/jpg");
            //return View();
            return Json(new Product
            {
                Id = 1,
                Name = "Test",
            });
        }
        public IActionResult About()
        {
            return View();
            //return Content("First WebApp of About");
        }
        public IActionResult Contact()
        {
            //return View();
            return Content("First WebApp of Contact");
        }
    }

}
