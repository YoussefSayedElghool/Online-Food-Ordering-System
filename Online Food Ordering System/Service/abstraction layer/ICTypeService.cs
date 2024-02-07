using Online_Food_Ordering_System.Models;
using Online_Food_Ordering_System.Views;

namespace Online_Food_Ordering_System.Service.abstraction_layer
{
    public interface ICTypeService
    {
        List<CType> GetAllCType();
        CTypeFilterViewModel GetAllCType(int id);
    }
}
