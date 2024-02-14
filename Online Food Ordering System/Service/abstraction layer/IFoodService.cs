using Online_Food_Ordering_System.Models;
using Online_Food_Ordering_System.View_Models;

namespace Online_Food_Ordering_System.Service.abstraction_layer
{
    public interface IFoodService
    {
        List<FoodCardVeiwModel>? GetAllFood();
        List<FoodCardVeiwModel>? GetByCTypeId(int id);
        Food GetById(int id);
        void Insert(Food item);
        void Edit(Food item);
        void Delete(int id);
    }
}
