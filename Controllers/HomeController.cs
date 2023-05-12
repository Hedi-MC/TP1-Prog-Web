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

            int MageCombat = DB.Enfants.Where(e => e.TypeAbilite == "Combat" && e.ParentId == 1).Count();
            DB.Parents[0].CombatSkills=MageCombat;

            int MageUtility = DB.Enfants.Where(e => e.TypeAbilite == "Utilité" && e.ParentId == 1).Count();
            DB.Parents[0].UtilitySkills = MageUtility;

            int MageUpgrade = DB.Enfants.Where(e => e.TypeAbilite == "Amélioration" && e.ParentId == 1).Count();
            DB.Parents[0].UpgradeSkills = MageUpgrade;


            int WarriorCombat = DB.Enfants.Where(e => e.TypeAbilite == "Combat" && e.ParentId == 2).Count();
            DB.Parents[1].CombatSkills = WarriorCombat;

            int WarriorUtility = DB.Enfants.Where(e => e.TypeAbilite == "Utilité" && e.ParentId == 2).Count();
            DB.Parents[1].UtilitySkills = WarriorUtility;

            int WarriorUpgrade = DB.Enfants.Where(e => e.TypeAbilite == "Amélioration" && e.ParentId == 2).Count();
            DB.Parents[1].UpgradeSkills= WarriorUpgrade;


            int ThiefCombat = DB.Enfants.Where(e => e.TypeAbilite == "Combat" && e.ParentId == 3).Count();
            DB.Parents[2].CombatSkills = ThiefCombat;

            int ThiefUtility = DB.Enfants.Where(e => e.TypeAbilite == "Utilité" && e.ParentId == 3).Count();
            DB.Parents[2].UtilitySkills = ThiefUtility;

            int ThiefUpgrade = DB.Enfants.Where(e => e.TypeAbilite == "Amélioration" && e.ParentId == 3).Count();
            DB.Parents[2].UpgradeSkills= ThiefUpgrade;


            ViewData["Parents"] = DB.Parents;           //mon quota de viewdata <B)
            return View(DB.Parents);


            
        }
    }
}
