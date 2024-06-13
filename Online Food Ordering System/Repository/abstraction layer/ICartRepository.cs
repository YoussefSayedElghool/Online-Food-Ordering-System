using Online_Food_Ordering_System.Models;

namespace Online_Food_Ordering_System.Repository.abstraction_layer
{
    public interface ICartRepository
    {
        List<Cart> GetAll();
        Cart GetById(int id);
        void Insert(Cart item);
        void Edit(Cart item);
        void Delete(int id);
    }
}
