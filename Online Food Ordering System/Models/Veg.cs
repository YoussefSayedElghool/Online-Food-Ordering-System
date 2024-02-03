using Microsoft.Extensions.Hosting;

namespace Online_Food_Ordering_System.Models
{
    public class Veg
    {
        public int VegId { get; set; }
        public int Type { get; set; }
        public ICollection<Food> Foods { get; } = new List<Food>();
    }
}
