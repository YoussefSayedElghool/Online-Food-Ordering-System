using Microsoft.Extensions.Hosting;

namespace Online_Food_Ordering_System.Models
{
    public class Veg
    {
        public int VegId { get; set; }
        public string Type { get; set; }
        public virtual ICollection<Food> Foods { get; } = new List<Food>();
    }
}
