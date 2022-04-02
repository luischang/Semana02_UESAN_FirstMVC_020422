using Microsoft.AspNetCore.Mvc;

namespace Semana02_UESAN_FirstMVC.Controllers
{
    public class SecurityController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
