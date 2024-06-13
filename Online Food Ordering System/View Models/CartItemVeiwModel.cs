using Online_Food_Ordering_System.Models;
using System.ComponentModel.DataAnnotations;

namespace Online_Food_Ordering_System.View_Models
{
    public class CartItemVeiwModel
    {
        public int CartId { get; set; }
        public required int FoodId { get; set; }
        public required string Name { get; set; }
        public required decimal Price { get; set; }
        public required string Image { get; set; }
        [Range(1 , 10_000)]
        public required int Quntity { get; set; }


    }
}
