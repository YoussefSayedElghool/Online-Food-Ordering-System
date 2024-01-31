namespace Online_Food_Ordering_System.Models
{

    public enum Dirction { 
    right,
    left
    }

    public class Advantage
    {
        public required string title { get; set; }
        public required string pahpargraph { get; set; }
        public required string imge { get; set; }
        public required Dirction dirction { get; set; }

    }
}
