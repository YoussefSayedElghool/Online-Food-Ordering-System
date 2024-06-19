using Online_Food_Ordering_SysBtem.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Food_Ordering_System.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }

        [ForeignKey("Invoice")]
        public int InvoiceId { get; set; }

        [ForeignKey("Food")]
        public int FoodId { get; set; }        
        public int Quntity { get; set; }
        public decimal Price { get; set; }

        public virtual Invoice Invoice { get; set; } = null!;
        public virtual Food Food { get; set; } = null!;



    }
}
