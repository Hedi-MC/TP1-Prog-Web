using Microsoft.AspNetCore.Mvc;
using TP2_Skyrim.Models;

namespace TP2_Skyrim.Controllers
{
    public class EnfantController : Controller
    {
        private Database DB { get; set; }
        public EnfantController(Database db) { this.DB = db; }

        
        
        public IActionResult Recherche()
        {
            List<Enfant> enfants = new List<Enfant>();
            ViewData["Enfants"] = DB.Enfants;
            return View(DB.Enfants);
        }
        [Route("/Enfant/Detail/{id?}")]
        public IActionResult Detail(int? id)
        {
            if(id == null) return View(null);
            foreach(Enfant ef in DB.Enfants) 
            {
                if(ef.EnfantId== id) { return View(ef); }
            }
            return View(null);



  
        }
    }
}
