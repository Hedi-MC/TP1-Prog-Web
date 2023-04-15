using TP2_Skyrim.Models;

namespace TP2_Skyrim.Viewmodels
{
    public class PageRechercheViewModel

    {
        public CritereRechercheViewModel Criteres { get; set; }

        public List<Enfant> Resultat { get; set; }
    }
}
