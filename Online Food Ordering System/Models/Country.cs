using Online_Food_Ordering_SysBtem.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Food_Ordering_System.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string Name { get; set; }

        public virtual List<City> Cities { get; } = [];
    }
}
