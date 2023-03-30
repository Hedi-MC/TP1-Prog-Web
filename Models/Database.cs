namespace TP2_Skyrim.Models
{
    public class Database
    {
        public List<Parent> Parents { get; set; }

        public List<Enfant> Enfants { get; set; }

        public Database()
        {
            Enfants = new List<Enfant>();
            Parents = new List<Parent>();

            Parents.Add(new Parent() { ParentId = 1, Nom = "Le Mage", ImageURL = "wwwroot\images\mage.jpg", Description = "insert description here", CombatSkills = 3, UtilitySkills = 2, UpgradeSkills = 1 });
            
        }


    }
}
