using Online_Food_Ordering_System.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Online_Food_Ordering_System.View_Models
{
    public class FoodForm : IImageFile
    {

        public int FoodId { get; set; }

        [DisplayName("food name")]
        [MaxLength(500)]
        [MinLength(2)]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [DisplayName("food price")]
        [DataType(DataType.Currency)]
        [Range(0.01, 100_000_000)]
        public decimal Price { get; set; }

        [DisplayName("food description")]
        [DataType(DataType.MultilineText)]
        [MaxLength(5000)]
        [MinLength(10)]
        public string Description { get; set; }

        [DisplayName("food imge")]
        [DataType(DataType.Upload)]
        public IFormFile? ImageFile { get; set; }
        
        [DisplayName("visible")]
        public bool IsVisible { get; set; } = true;

        [DisplayName("food type")]
        public int CTypeId { get; set; }
        
        [DisplayName("vegetarian type")]
        public int VegId { get; set; }
        public  List<CType>? CTypes { get; set; } = null!;
        public List<Veg>? Vegs { get; set; } = null!;
        public string? ImageSrc { get; set; } = "";
        public List<string>? OldImages { get; set; }
    }
}
