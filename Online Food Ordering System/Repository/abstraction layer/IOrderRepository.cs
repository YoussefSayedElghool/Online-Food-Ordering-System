using Online_Food_Ordering_System.Models;

namespace Online_Food_Ordering_System.Repository
{
    public interface IOrderRepository
    {
        List<Order> GetAll();
        Order GetById(int id);
        void Insert(Order item);
        void Edit(Order item);
        void Delete(int id);
    }
}
