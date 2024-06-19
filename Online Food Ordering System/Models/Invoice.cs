using Online_Food_Ordering_System.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Food_Ordering_SysBtem.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public DateTime ReleaseDate { get; set; } = DateTime.Now;


        [ForeignKey("Status")]
        public int OrderStatusId { get; set; }        
        
        [ForeignKey("PaymentMethod")]
        public int PaymentMethodId { get; set; }

        [ForeignKey("User")]
        public required string UserId { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual List<OrderItem> FoodInvoices { get; } = [];
        public virtual OrderStatus Status { get; set; } = null!;
        public virtual PaymentMethod PaymentMethod { get; set; } = null!;


    }
}
