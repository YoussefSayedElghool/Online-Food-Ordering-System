using Online_Food_Ordering_System.Models;
using Online_Food_Ordering_System.View_Models;

namespace Online_Food_Ordering_System.Service.abstraction_layer
{
    public interface IFoodService
    {
        List<FoodCardVeiwModel>? GetAllFood();
    }
}
