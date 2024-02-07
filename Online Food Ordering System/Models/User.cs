using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Online_Food_Ordering_System.Models
{
    public class User:IdentityUser
    {
        public required string Address { get; set; }
        public required string DisplayName { get; set; }
        public string Image { get; set; }
        public virtual List<Rating> Ratings { get; } = [];
        public virtual List<Order> Orders { get; } = [];

    }
}
