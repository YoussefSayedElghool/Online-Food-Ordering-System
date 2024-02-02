using System.ComponentModel.DataAnnotations;
using static NuGet.Packaging.PackagingConstants;

namespace Online_Food_Ordering_System.Models
{
    public class Order
    {
        public required int OrderId { get; set; }
        public required string UserId { get; set; }
        public Food Food { get; set; } = null!;
        public User User { get; set; } = null!;
        public required string status { get; set; }
    }
}
