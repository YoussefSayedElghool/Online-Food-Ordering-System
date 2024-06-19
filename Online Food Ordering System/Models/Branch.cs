using Online_Food_Ordering_SysBtem.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Food_Ordering_System.Models
{
    public class Branch
    {
        public int BranchId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        [ForeignKey("User")]
        public string CasherId { get; set; }       
        
        [ForeignKey("City")]
        public int CityId { get; set; }

        public virtual User Casher { get; set; } = null!;
        public virtual City City { get; set; } = null!;
    }
}
