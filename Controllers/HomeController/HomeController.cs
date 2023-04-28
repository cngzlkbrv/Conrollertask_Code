using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers.HomeController
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
