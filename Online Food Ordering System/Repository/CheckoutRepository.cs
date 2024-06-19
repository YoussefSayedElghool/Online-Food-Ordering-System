using Online_Food_Ordering_SysBtem.Models;
using Online_Food_Ordering_System.Models;
using Online_Food_Ordering_System.Repository.abstraction_layer;

namespace Online_Food_Ordering_System.Repository
{
    public class CheckoutRepository : ICheckoutRepository
    {

        AppDbContext context;
        private readonly IInvoiceRepository invoiceRepository;
        private readonly ICartRepository cartRepository;
        private readonly IOrderItemsRepository foodInvoiceRepository;

        public CheckoutRepository(AppDbContext _context, IInvoiceRepository invoiceRepository , ICartRepository cartRepository , IOrderItemsRepository foodInvoiceRepository)
        {
            context = _context;
            this.invoiceRepository = invoiceRepository;
            this.cartRepository = cartRepository;
            this.foodInvoiceRepository = foodInvoiceRepository;
        }

        public void MakeOrder(string userId)
        {
            using var transaction = context.Database.BeginTransaction();

            try
            {
                Invoice invoice = invoiceRepository.Insert(new Invoice() { UserId = userId });
              
                List<Cart> carts = cartRepository.GetByUserId(userId);

                foreach (var cart in carts) { 

                foodInvoiceRepository.Insert(new OrderItem() {
                    
                    FoodId = cart.FoodId , 
                    InvoiceId = invoice.InvoiceId,
                    Quntity = cart.Quntity,
                    Price = cart.Food.Price
                });

                }

                foreach (var cart in carts)
                {
                    cartRepository.Delete(cart.CartId);
                }

                context.SaveChanges();
                transaction.Commit();
            }
            catch (Exception)
            {
                // TODO: Handle failure
            }



        }

    }
}

