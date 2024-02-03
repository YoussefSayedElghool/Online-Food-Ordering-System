using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Food_Ordering_System.Models
{
    public class Rating
    {
        public required int RatingId { get; set; }
        
        [ForeignKey("Food")]
        public required int FoodId { get; set; }
        
        [ForeignKey("User")]
        public required string UserId { get; set; }
        
        public Food Food { get; set; } = null!;
        public User User { get; set; } = null!;
    }
}
