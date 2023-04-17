namespace TP2_Skyrim.Models
{
    public class Parent
    {
        //ID du parent, pour identifier avec les enfants (de 1 à 3)
        public int ParentId { get; set; }

        //La liste de tous les enfants d'un parent
        public List<Enfant> Enfants { get; set; }

        //le nom du parent (mage, guerrier, voleur)
        public String Nom { get; set; }

        //url de l'image pour la page d'accueil
        public String ImageURL { get; set; }

        //la description sur la page d'accueil
        public String Description { get; set; }

        //le nombre d'habiletés de combat pour le parent
        public int CombatSkills { get; set; }
        //le nombre d'habiletés d'utilité pour le parent
        public int UtilitySkills { get; set; }
        //le nombre d'habiletés d'amélioration pour le parent
        public int UpgradeSkills { get; set; }


    }
}
