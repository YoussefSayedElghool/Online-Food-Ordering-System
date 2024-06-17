using Online_Food_Ordering_System.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Food_Ordering_SysBtem.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public DateTime ReleaseDate { get; set; } = DateTime.Now;

        [ForeignKey("User")]
        public required string UserId { get; set; }
        public virtual User User { get; set; } = null!;
        public virtual List<FoodInvoice> FoodInvoices { get; } = [];

    }
}
