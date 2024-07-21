using FirstWebAppPB301.Models;
using FirstWebAppPB301.ViewModels;
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
            //ViewData["name"] = "Emil";
            //ViewBag.age = 27;
            //TempData["address"] = "Baki";
            //return RedirectToAction(nameof(About));
            List<Student> students = new List<Student>(){
                new(){Id = 1,Name="Student1"},
                new(){Id = 2,Name="Student2"},
                new(){Id = 3,Name="Student3"},
                new(){Id = 4,Name="Student4"}
            };
            ViewBag.Students = students;
            HomeVM homeVM = new HomeVM();
            homeVM.GroupName = "PB301";
            homeVM.Student=students[0];
            homeVM.Students = students;
            return View(homeVM);
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
