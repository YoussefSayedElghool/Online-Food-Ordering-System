using Online_Food_Ordering_System.Models;
using Online_Food_Ordering_System.Repository.abstraction_layer;

namespace Online_Food_Ordering_System.Repository
{
    public class OrderItemsRepository : IOrderItemsRepository
    {

        AppDbContext context;
        public OrderItemsRepository(AppDbContext _context)
        {
            context = _context;
        }

        public List<OrderItem> GetAll()
        {
            return context.OrderItems.ToList();
        }
        public OrderItem GetById(int id)
        {
            return context.OrderItems.FirstOrDefault(x => x.OrderItemId== id);
        }

        public void Insert(OrderItem item)
        {
            context.OrderItems.Add(item);
            context.SaveChanges();
        }

        public void Edit(OrderItem item)
        {
                context.OrderItems.Update(item);
                context.SaveChanges();
        }

        public void Delete(int id)
        {
            OrderItem old = GetById(id);
            context.OrderItems.Remove(old);
            context.SaveChanges();
        }
    }
}

