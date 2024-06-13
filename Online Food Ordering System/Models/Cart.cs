using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Food_Ordering_System.Models
{
    [Index(nameof(UserId), nameof(FoodId) , IsUnique = true)]
    public class Cart
    {
        public int CartId { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }

        [ForeignKey("Food")]
        public int FoodId { get; set; }
        public int Quntity { get; set; } = 1;

        public virtual Food Food { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
