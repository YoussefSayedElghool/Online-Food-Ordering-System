namespace Online_Food_Ordering_System.Models
{
    public class CType
    {
        public int CTypeId { get; set; }
        public int Type { get; set; }
        public ICollection<Food> Foods { get; } = new List<Food>();
    }
}
