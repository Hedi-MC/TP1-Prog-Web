using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TP2_Skyrim.Models;

namespace TP2_Skyrim.Controllers
{
    public class FavorisController : Controller
    {

        private Database DB { get; set; }
        public FavorisController(Database db) { this.DB = db; }


        
        public IActionResult AjouterUnEnfant(int id)
        {
            List<int> enfants = HttpContext.Session.Get<List<int>>("enfantIDs");

            if (enfants == null) { enfants = new List<int>(); }

            if (!enfants.Contains(id))
            {
                enfants.Add(id);
            }

            HttpContext.Session.Set<List<int>>("enfantIDs", enfants);

            return RedirectToAction("Index");
        }

        [Route("/Favoris/Index")]
        [Route("/Favoris")]
        public IActionResult Index()
        {
            var enfantIDs = HttpContext.Session.Get<List<int>>("enfantIDs");
            if(enfantIDs == null)
            {
                enfantIDs = new List<int>();
            }

            var enfantBD=DB.Enfants.Where(e=>enfantIDs.Contains(e.EnfantId)).ToList();


            return View(enfantBD);
        }


       
        public IActionResult SupprimerUnEnfant(int id)
        {
            List<int> enfants = HttpContext.Session.Get<List<int>>("enfantIDs");

            if (enfants == null) { enfants = new List<int>(); }

            enfants.Remove(id);

            HttpContext.Session.Set<List<int>>("enfantIDs", enfants);

            return RedirectToAction("Index");
        }
    }
}
