﻿using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace Online_Food_Ordering_System.Models
{
    public class Food
    {
        public int FoodId { get; set; }
        public required string Name { get; set; }
        public required decimal Price { get; set; }
        public required string Description { get; set; }
        public required string Image { get; set; }
        public required bool IsVisible { get; set; } = true;

        public int CTypeId { get; set; }
        public virtual CType CType { get; set; } = null!;
        
        public int VegId { get; set; }
        public virtual Veg Veg { get; set; } = null!;

        public virtual List<Rating> Ratings { get; } = [];
        public virtual List<Order> Orders { get; } = [];

    }
}
