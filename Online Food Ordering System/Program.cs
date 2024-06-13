using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Online_Food_Ordering_System.Models;
using Online_Food_Ordering_System.Repository;
using Online_Food_Ordering_System.Repository.abstraction_layer;
using Online_Food_Ordering_System.Service;
using Online_Food_Ordering_System.Service.abstraction_layer;
using Online_Food_Ratinging_System.Repository;
using System.Security.Principal;

namespace Online_Food_Ordering_System
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<AppDbContext>(optionBuilder =>
            {

                optionBuilder.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("cs"));
            });

            builder.Services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();

            // Register 
            builder.Services.AddScoped<IFoodRepository, FoodRepository>();
            builder.Services.AddScoped<IRatingRepository, RatingRepository>();
            builder.Services.AddScoped<IFoodService, FoodService>();
            builder.Services.AddScoped<ICTypeRepository, CTypeRepository>();
            builder.Services.AddScoped<ICTypeService, CTypeService>();
            builder.Services.AddScoped<IVegTypeRepository, VegTypeRepository>();
            builder.Services.AddScoped<ICartRepository, CartRepository>();
            builder.Services.AddScoped<ICartService, CartService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();


            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");


           
            app.Run();
        }
    }
}
