using Microsoft.AspNetCore.Mvc;
using TP2_Skyrim.Models;
using TP2_Skyrim.Viewmodels;

namespace TP2_Skyrim.Controllers
{
    public class EnfantController : Controller
    {
        private Database DB { get; set; }
        public EnfantController(Database db) { this.DB = db; }


        [Route("/Enfant/Recherche")]
        public IActionResult Recherche()
        {

            //Les criteres c'est hard laid, mais je fais ce que je peux

            //on mets les criteres en true histoire que les trucs show up au début
            var model = new PageRechercheViewModel();
            model.Criteres = new CritereRechercheViewModel();
            model.Criteres.EstMage = true;
            model.Criteres.EstGuerrier = true;
            model.Criteres.EstVoleur = true;
            model.Resultat = DB.Enfants.ToList();
            ViewData["Enfants"] = DB.Enfants;
            return View(model);




            //List<Enfant> enfants = new List<Enfant>();
            // ViewData["Enfants"] = DB.Enfants;
            // return View(DB.Enfants);
        }

        // /||| #let there be dung# |||\


        // des routes, prennent un id qui peut être nullable et spécifie que c'est un-
        //-int pour éviter des faire des conflict avec l'url à nom 
        // (il assume que l'url est toujours un string)
        [Route("/Enfant/Detail/{id:int?}")]
        [Route("/Enfant/{id:int?}")]
        [Route("/{id:int?}")]
        public IActionResult DetailParID(int? id)
        {
            if (id == null) return View("NotFound"); //un beau 404 page si ya rien
            foreach (Enfant ef in DB.Enfants)
            {
                if (ef.EnfantId == id) { return View("Detail", ef); } //retourne detail pour qu'il sache quel cshtml utiliser + le actual enfant
            }
            return View("NotFound");    //si ca mess up somehow, on mets un 404




        }


        //des routes qui prennent le nom d'un enfant
        [Route("/Enfant/Detail/{nom}")]
        [Route("/Enfant/{nom}")]
        [Route("/{nom}")]
        public IActionResult DetailParNom(String nom)
        {
            if (nom == null) return View("NotFound"); //un beau 404 page si ya rien
            foreach (Enfant ef1 in DB.Enfants)
            {
                if (ef1.Nom.ToLower() == nom.ToLower()) { return View("Detail", ef1); } //retourne detail pour qu'il sache quel cshtml utiliser 
                                                                                        // et le actual enfant, en lowercase pour que ce soit case insensitive

            }
            return View("NotFound");    //si ca mess up somehow, on mets un 404




        }

    }
}
