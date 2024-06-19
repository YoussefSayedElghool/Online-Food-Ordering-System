using Online_Food_Ordering_System.Models;
using Online_Food_Ordering_System.Repository.abstraction_layer;

namespace Online_Food_Ordering_System.Repository
{
    public class CartRepository : ICartRepository
    {

        AppDbContext context;
        public CartRepository(AppDbContext _context)
        {
            context = _context;
        }

        public List<Cart> GetAll()
        {
            return context.Carts.ToList();
        }
        public Cart GetById(int id)
        {
            return context.Carts.FirstOrDefault(x => x.CartId== id);
        }

        public List<Cart> GetByUserId(string userId)
        {
            return context.Carts.Where(x => x.UserId == userId).ToList();
        }

        public void Insert(Cart item)
        {
            Cart? cart = context.Carts.FirstOrDefault(c => (c.UserId == item.UserId) && (c.FoodId == item.FoodId));
            if (cart is null)
            {
                context.Carts.Add(item);
            }
            else {
                cart.Quntity = cart.Quntity + 1;
            }
            context.SaveChanges();
        }

        public void Edit(Cart item)
        {
            
                context.Carts.Update(item);
                context.SaveChanges();
            
        }

        public void Delete(int id)
        {
            Cart old = GetById(id);
            context.Carts.Remove(old);
            context.SaveChanges();
        }


    }
}

