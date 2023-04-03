namespace TP2_Skyrim.Models
{
    public class Enfant
    {
        public int EnfantId { get; set; }

        public int ParentId { get; set; }

        public Parent Parent { get; set; }
        
        public String ImageURL { get; set; }

        public String Nom { get; set; }

        public String Description { get; set; }

        public int NbrCompetences { get; set; }
        
        public String UtilGen { get; set; }

        public String TypeAbilite { get; set; }

        public int NiveauDeRecommendation { get; set; }

        public int Difficulté { get; set; }
    }
}
