using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static NuGet.Packaging.PackagingConstants;

namespace Online_Food_Ordering_System.Models
{
    public class Order
    {
        public required int OrderId { get; set; }

        [ForeignKey("User")]
        public required string UserId { get; set; }
        
        [ForeignKey("Food")]
        public required int FoodId { get; set; }
      
        public required int Quantity { get; set; }
        public required string Status { get; set; }

        public Food Food { get; set; } = null!;
        public User User { get; set; } = null!;
    }
}
