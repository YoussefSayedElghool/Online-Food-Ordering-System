using Online_Food_Ordering_System.Models;

namespace Online_Food_Ordering_System.Repository
{
    public class OrderRepository : IOrderRepository
    {

        AppDbContext context;
        public OrderRepository(AppDbContext _context)
        {
            context = _context;
        }

        public List<Order> GetAll()
        {
            return context.Orders.ToList();
        }
        public Order GetById(int id)
        {
            return context.Orders.FirstOrDefault(x => x.OrderId == id);
        }

        public void Insert(Order item)
        {
            context.Orders.Add(item);
            context.SaveChanges();
        }

        public void Edit(Order item)
        {
            context.Update(item);
            context.SaveChanges();

        }

        public void Delete(int id)
        {
            Order old = GetById(id);
            context.Orders.Remove(old);
            context.SaveChanges();
        }

    }

}
