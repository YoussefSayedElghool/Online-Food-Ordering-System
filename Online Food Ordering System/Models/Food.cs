using System.ComponentModel.DataAnnotations;

namespace Online_Food_Ordering_System.Models
{
    public class Food
    {
        public int FoodId { get; set; }

        public required string Name { get; set; }
        public required string CType { get; set; }
        public required bool Veg_Non { get; set; }
        public required string Description { get; set; }
        public List<Rating> Ratings { get; } = [];
        public List<Order> Orders { get; } = [];

    }
}
