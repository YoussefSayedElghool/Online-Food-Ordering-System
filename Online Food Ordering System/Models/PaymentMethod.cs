using Online_Food_Ordering_SysBtem.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Food_Ordering_System.Models
{
    public class PaymentMethod
    {
        public int PaymentMethodId { get; set; }
        public string Method { get; set; }

        public virtual List<Invoice> Invoices { get; } = [];
    }
}
