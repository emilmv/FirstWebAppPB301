using Microsoft.AspNetCore.Mvc;

namespace FirstWebAppPB301.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
