namespace TP2.Models
{
    public class Parent
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public string Logo { get; set; }
        
        public List<Enfant> Enfants { get; set; }

        public string description { get; set; }

        public int nbreHéros { get; set; }

        public string pointFort { get; set; }
    }
}
