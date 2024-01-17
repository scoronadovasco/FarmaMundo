using Microsoft.AspNetCore.Mvc;

namespace FarmaMundo.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
