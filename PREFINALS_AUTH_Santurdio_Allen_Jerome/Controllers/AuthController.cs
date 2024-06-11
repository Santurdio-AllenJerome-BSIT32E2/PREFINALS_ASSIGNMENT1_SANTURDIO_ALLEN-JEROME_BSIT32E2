using Microsoft.AspNetCore.Mvc;

namespace PREFINALS_AUTH_Santurdio_Allen_Jerome.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
