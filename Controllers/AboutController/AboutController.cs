using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers.AboutController
{
    public class AboutController:Controller
    {
        public IActionResult Index(int id) { return View(); }
    }
}
