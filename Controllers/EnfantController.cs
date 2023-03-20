using Microsoft.AspNetCore.Mvc;

namespace TP2_Skyrim.Controllers
{
    public class EnfantController : Controller
    {
        public IActionResult Recherche()
        {
            return View();
        }
        
        public IActionResult Detail()
        {
            return View();
        }
    }
}
