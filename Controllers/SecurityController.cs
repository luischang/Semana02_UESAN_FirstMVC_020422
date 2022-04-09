using Microsoft.AspNetCore.Mvc;

namespace Semana02_UESAN_FirstMVC.Controllers
{
    public class SecurityController : Controller
    {
        public IActionResult Login()
        {
            ViewData["WelcomeMessage"] = "Bienvenido a la página de inicio de sesión";
            return View();
        }
    }
}
