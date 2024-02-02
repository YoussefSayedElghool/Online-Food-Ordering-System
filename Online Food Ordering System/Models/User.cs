using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Online_Food_Ordering_System.Models
{
    public class User:IdentityUser
    {
        public required string Address { get; set; }
        public List<Rating> Ratings { get; } = [];
        public List<Order> Orders { get; } = [];

    }
}
