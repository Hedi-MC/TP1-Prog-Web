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
        }

        [Route("/Enfant/Filtrer")]
        public IActionResult Filtrer(CritereRechercheViewModel criteres)
        {
            IEnumerable<Enfant> don = DB.Enfants;
            List<Enfant> debug = new List<Enfant>();

           
            if(criteres.MotsCles != null){ don = don.Where(e => e.Nom.ToLower().Contains(criteres.MotsCles.ToLower())); }//on check les mots clés

            if (criteres.NbrCompMin != null) { don = don.Where(e => e.NbrCompetences >= criteres.NbrCompMin); } //on check les nombres de skills min

            if (criteres.NbrCompMax != null) { don = don.Where(e => e.NbrCompetences <= criteres.NbrCompMax); } //on check les nombres de skills max



            if (criteres.ChoixHabileteVedette == "oui")     //si on select oui, on check ceux qui sont true
            {
                don = don.Where(e => e.Vedette == true);
            }
            else if (criteres.ChoixHabileteVedette == "non")    //si on select non, on check ceux qui sont false
            {
                don = don.Where(e => e.Vedette == false);
            }

            List<Enfant> classes = new List<Enfant>(don);

            
            if (criteres.EstMage == true)                       //check si le parent est Mage
            {
                debug.AddRange(classes.Where(e => e.Parent.Nom == "Le Mage"));
            }
            

            if (criteres.EstGuerrier == true)                   //check si le parent est Guerrier
            {
                debug.AddRange(classes.Where(e => e.Parent.Nom == "Le Guerrier"));
            }
            
            if (criteres.EstVoleur == true)                     //check si le parent est Voleur
            {
                debug.AddRange(classes.Where(e => e.Parent.Nom == "Le Voleur"));
            }
            
            PageRechercheViewModel page=new PageRechercheViewModel();
            page.Criteres = criteres;
            page.Resultat = debug;

            return View("Recherche",page);

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
