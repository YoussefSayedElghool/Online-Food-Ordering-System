using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Online_Food_Ordering_System.Models
{
    public class AppDbContext :IdentityDbContext<User>
    {
            public AppDbContext(DbContextOptions options) : base(options)
            {

            }

            public DbSet<Food> Foods { get; set; }
            public DbSet<Rating> Ratings { get; set; }
            public DbSet<Order> Orders { get; set; }
            public DbSet<Veg> Vegs { get; set; }
            public DbSet<CType> CTypes { get; set; }

           
    }
}
