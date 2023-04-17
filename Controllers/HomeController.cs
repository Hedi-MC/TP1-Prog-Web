using Microsoft.AspNetCore.Mvc;
using TP2_Skyrim.Models;

namespace TP2_Skyrim.Controllers
{
    public class HomeController : Controller
    {
        private Database DB { get; set; }

        public HomeController(Database db) { this.DB = db; }


        [Route("")]                 //c'est la page par défaut, sinon ca faisait un 404 
        [Route("/Home/Index")]      //jvoulais pas rewrite mes boutons
        public IActionResult Index()
        {
            List<Parent> parents = new List<Parent>();
            ViewData["Parents"] = DB.Parents;           //mon quota de viewdata <B)
            return View(DB.Parents);    
        }
    }
}
