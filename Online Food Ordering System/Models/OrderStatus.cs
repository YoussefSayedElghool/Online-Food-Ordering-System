using Online_Food_Ordering_SysBtem.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Food_Ordering_System.Models
{
    public class OrderStatus
    {
        public int OrderStatusId { get; set; }
        public string Status { get; set; }

        public virtual List<Invoice> Invoices { get; } = [];

    }
}
