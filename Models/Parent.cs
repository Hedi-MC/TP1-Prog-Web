namespace TP2_Skyrim.Models
{
    public class Parent
    {
       public int ParentId { get; set; }

       public List<Enfant> Enfants { get; set; }

       public String Nom { get; set; }

        public String ImageURL { get; set; }

        public String Description { get; set; }

        public int CombatSkills { get; set; }

       public int UtilitySkills { get; set; }

       public int UpgradeSkills { get; set; }

      
    }
}
