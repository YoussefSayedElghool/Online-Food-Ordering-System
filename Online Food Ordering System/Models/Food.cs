using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;

namespace Online_Food_Ordering_System.Models
{
    public class Food
    {
        public int FoodId { get; set; }

        [DisplayName("food name")]
        [MaxLength(500)]
        [MinLength(2)]
        [DataType(DataType.Text)]
        public required string Name { get; set; }

        [DisplayName("food price")]
        [DataType(DataType.Currency)]
        [Range(0.01 , 100_000_000)]
        public required decimal Price { get; set; }

        [DisplayName("food description")]
        [DataType(DataType.MultilineText)]
        [MaxLength(5000)]
        [MinLength(100)]
        public required string Description { get; set; }

        [DisplayName("food imge")]
        [DataType(DataType.ImageUrl)]
        public required string Image { get; set; }
        public required bool IsVisible { get; set; } = true;

        
        public int CTypeId { get; set; }
        public virtual CType? CType { get; set; } = null!;
        
        public int VegId { get; set; }
        public virtual Veg? Veg { get; set; } = null!;

        public virtual List<Rating> Ratings { get; } = [];
        public virtual List<Cart> Carts { get; } = [];
        public virtual List<FoodInvoice> FoodInvoices { get; } = [];

    }
}
