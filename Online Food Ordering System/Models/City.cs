using Online_Food_Ordering_SysBtem.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Food_Ordering_System.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string Name { get; set; }

        [ForeignKey("Country")]
        public int CountryId { get; set; }

        public virtual Country Country { get; set; } = null!;
        public virtual List<Branch> Branches { get; } = [];

    }
}
