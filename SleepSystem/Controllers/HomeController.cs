using Microsoft.AspNetCore.Mvc;

namespace SleepSystem.Controllers
{
    public class HomeController : Controller
    {
        // Acción para la página principal
        public IActionResult Index()
        {
            return View();
        }
    }
}
