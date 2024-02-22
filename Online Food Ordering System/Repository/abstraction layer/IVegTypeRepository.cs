using Online_Food_Ordering_System.Models;

namespace Online_Food_Ordering_System.Repository.abstraction_layer
{
    public interface IVegTypeRepository
    {
        List<Veg> GetAll();
        Veg GetById(int id);
        void Insert(Veg item);
        void Edit(Veg item);
        void Delete(int id);
    }
}
