using Microsoft.AspNetCore.Mvc;

namespace UniComparer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}