using Online_Food_Ordering_System.Models;

namespace Online_Food_Ordering_System.Repository.abstraction_layer
{
    public interface ICheckoutRepository
    {
        void MakeOrder(string userId);
    }
}
