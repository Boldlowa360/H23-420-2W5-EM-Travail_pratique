namespace TP2.Models
{
    public class Enfant
    {
        public string nom { get; set; }

        public int id { get; set; }

        public int IdParent { get; set; }

        public Parent Parent { get; set; }

        public int age { get; set; }

        public string nationnalité { get; set; }

        public string image { get; set; }
        
        public string description { get; set; }
        
        public string Role { get; set; }

        public int difficulté { get; set; }

        public int hp { get; set; }
    }
}
