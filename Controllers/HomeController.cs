using Microsoft.AspNetCore.Mvc;
using TP2_Skyrim.Models;

namespace TP2_Skyrim.Controllers
{
    public class HomeController : Controller
    {
        private Database DB { get; set; }

        public HomeController(Database db) { this.DB = db; }
        
        
        [Route("")]
        [Route("/Home/Index")]
        public IActionResult Index()
        {
            List<Parent> parents = new List<Parent>();
            ViewData["Parents"] = DB.Parents;
            return View(DB.Parents);
        }
    }
}
