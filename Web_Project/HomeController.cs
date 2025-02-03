using Microsoft.AspNetCore.Mvc;

namespace Web_Project
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
