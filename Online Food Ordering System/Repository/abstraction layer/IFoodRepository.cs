using Online_Food_Ordering_System.Models;

namespace Online_Food_Ordering_System.Repository
{
    public interface IFoodRepository
    {
        List<Food> GetAll();
        List<Food> GetByCTypeId(int id);
        Food GetById(int id);
        void Insert(Food item);
        void Edit(Food item);
        void Delete(int id);
    }
}
