using Online_Food_Ordering_System.Models;

namespace Online_Food_Ordering_System.Repository.abstraction_layer
{
    public interface IOrderItemsRepository
    {
        List<OrderItem> GetAll();
        OrderItem GetById(int id);
        void Insert(OrderItem item);
        void Edit(OrderItem item);
        void Delete(int id);
    }
}
