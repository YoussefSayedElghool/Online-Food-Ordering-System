namespace Online_Food_Ordering_System.Models
{
    public class CType
    {
        public int CTypeId { get; set; }
        public string Type { get; set; }
        public virtual ICollection<Food> Foods { get; } = new List<Food>();
    }
}
