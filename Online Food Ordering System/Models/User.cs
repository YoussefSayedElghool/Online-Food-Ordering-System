using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Online_Food_Ordering_System.Models
{
    public class User:IdentityUser
    {
        public required string Address { get; set; }
        public virtual List<Rating> Ratings { get; } = [];
        public virtual List<Order> Orders { get; } = [];

    }
}
