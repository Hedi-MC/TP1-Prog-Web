namespace TP2_Skyrim.Viewmodels
{
    public class CritereRechercheViewModel
    {
        public string ChoixHabileteVedette { get; set; }

        public bool EstMage { get; set; }
        public bool EstGuerrier { get; set; }
        public bool EstVoleur { get; set; }

        public int? NbrCompMin { get; set; }

        public int? NbrCompMax { get; set; }

        public string MotsCles { get; set; }

    }
}
