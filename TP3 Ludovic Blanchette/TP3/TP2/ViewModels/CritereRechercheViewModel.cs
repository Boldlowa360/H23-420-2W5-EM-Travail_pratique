namespace TP2.ViewModels
{
    public class CritereRechercheViewModel
    {
        #region propriétés
        public string? Nom { get; set; }
        public int Difficulté { get; set; }
        public string? Vedette { get; set; }
        public bool Dps { get; set; }
        public bool Soigneur { get; set; }
        public bool Tank { get; set; }
        #endregion
    }
}
