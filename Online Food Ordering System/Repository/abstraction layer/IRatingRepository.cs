using Online_Food_Ordering_System.Models;

namespace Online_Food_Ordering_System.Repository.abstraction_layer
{
    public interface IRatingRepository
    {
        List<Rating> GetAll();
        Rating GetById(int id);
        void Insert(Rating item);
        void Edit(Rating item);
        void Delete(int id);
    }
}
