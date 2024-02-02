using System.ComponentModel.DataAnnotations;

namespace Online_Food_Ordering_System.Models
{
    public class Rating
    {
        public required int FoodId { get; set; }
        public required string UserId { get; set; }
        public Food Food { get; set; } = null!;
        public User User { get; set; } = null!;
    }
}
