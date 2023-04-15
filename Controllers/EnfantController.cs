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


        [Route("/Enfant/Detail/{id:int?}")]
        [Route("/Enfant/{id:int?}")]
        [Route("/{id:int?}")]
        public IActionResult DetailParID(int? id)
        {
            if(id == null) return View("NotFound");
            foreach(Enfant ef in DB.Enfants) 
            {
                if(ef.EnfantId== id) { return View("Detail",ef); }
            }
            return View("NotFound");



  
        }



        [Route("/Enfant/Detail/{nom}")]
        [Route("/Enfant/{nom}")]
        [Route("/{nom}")]
        public IActionResult DetailParNom(String nom)
        {
            if (nom == null) return View("NotFound");
            foreach (Enfant ef1 in DB.Enfants)
            {
                if (ef1.Nom.ToLower() ==nom.ToLower() ) { return View("Detail", ef1); }
            }
            return View("NotFound");




        }

    }
}
