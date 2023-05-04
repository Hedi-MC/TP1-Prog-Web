namespace TP2_Skyrim.Models
{
    public class Enfant
    {
        //ID de l'enfant (de 1 à 18)
        public int EnfantId { get; set; }

        //ID du parent associé à l'enfant, pour les joindres
        public int ParentId { get; set; }

        //Le nom du parent, pas necessaire mais rend les choses plus faciles.
        public Parent Parent { get; set; }

        //URL de l'image de l'enfant pour la page de recherche 
        public String ImageURL { get; set; }

        //Le nom de l'enfant (l'habileté)
        public String Nom { get; set; }

        //La Description à la page de détail
        public String Description { get; set; }

        //Le nombre de compétences (perks) pour l'habileté
        public int NbrCompetences { get; set; }

        //L'utilité générale pour tout les builds, moins bonne lorsque hautement spécialisé ou passable
        public String UtilGen { get; set; }

        //Le type d'abileté (combat, utilité, amélioration)
        public String TypeAbilite { get; set; }

        //A quel point je recommende d'investir dans l'habileté
        public int NiveauDeRecommendation { get; set; }

        //La difficulté pour level up l'habileté
        public int Difficulté { get; set; }

        //Image 1 du carousel, la constellation qui représente l'arbre de l'habileté
        public string Image1Logo { get; set; }

        //Image 2 du carousel, un screenshot directe du jeu, mettant en évident l'habileté
        public string Image2SS { get; set; }

        //Image 3 du carousel, de l'art du jeu elder scrolls legends en rapport avec l'habileté
        public string Image3Art { get; set; }

        //Est une Vedette
        public bool Vedette { get; set; }
    }

}
