using Online_Food_Ordering_System.Models;

namespace Online_Food_Ordering_System.View_Models
{
    public class FoodCardVeiwModel
    {
        public required string Name { get; set; }
        public required decimal Price { get; set; }
        public required decimal AvargeRating { get; set; }
        public required string Image { get; set; }
        public required string CType { get; set; } = null!;
        public required string VegType { get; set; }

    }
}
