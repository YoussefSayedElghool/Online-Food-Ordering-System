using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Online_Food_Ordering_SysBtem.Models;

namespace Online_Food_Ordering_System.Models
{
    public class AppDbContext :IdentityDbContext<User>
    {
            public AppDbContext(DbContextOptions options) : base(options)
            {

            }

            public DbSet<Food> Foods { get; set; }
            public DbSet<Rating> Ratings { get; set; }
            public DbSet<Cart> Carts { get; set; }
            public DbSet<Invoice> Invoices { get; set; }
            public DbSet<OrderItem> OrderItems { get; set; }
            public DbSet<OrderStatus> OrderStatuses { get; set; }
            public DbSet<PaymentMethod> PaymentMethods { get; set; }
            public DbSet<Branch> Branches { get; set; }
            public DbSet<Country> Countries { get; set; }
            public DbSet<City> Cities { get; set; }
            public DbSet<Veg> Vegs { get; set; }
            public DbSet<CType> CTypes { get; set; }

           
    }
}
