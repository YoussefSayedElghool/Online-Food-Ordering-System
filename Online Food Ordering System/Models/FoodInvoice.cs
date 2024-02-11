using Online_Food_Ordering_SysBtem.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Food_Ordering_System.Models
{
    public class FoodInvoice
    {
        public int FoodInvoiceId { get; set; }

        [ForeignKey("Invoice")]
        public int InvoiceId { get; set; }


        [ForeignKey("Food")]
        public required int FoodId { get; set; }

        public int Quntity { get; set; }

        public virtual Invoice Invoice { get; set; } = null!;
        public virtual Food Food { get; set; } = null!;


    }
}
