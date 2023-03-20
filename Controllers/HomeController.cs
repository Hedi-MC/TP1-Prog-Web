using Microsoft.AspNetCore.Mvc;

namespace TP2_Skyrim.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
