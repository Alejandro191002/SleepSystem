using Microsoft.AspNetCore.Mvc;
using SleepSystem.Models;

namespace SleepSystem.Controllers
{
    public class HomeController : Controller
    {
        // Acción para la página principal
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateUser(User_ model)
        {

            if (model == null)
            {
                return BadRequest("Modelo inválido");
            }

            return RedirectToAction("Index");
        }
    }

}


