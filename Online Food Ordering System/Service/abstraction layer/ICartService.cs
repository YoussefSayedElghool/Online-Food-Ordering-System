using Online_Food_Ordering_System.Models;
using Online_Food_Ordering_System.View_Models;

namespace Online_Food_Ordering_System.Service.abstraction_layer
{
    public interface ICartService
    {
        List<CartItemVeiwModel>? GetAllFoodAtCart();
        Cart GetById(int id);
        void AddToCart(int foodId, string userId);
        void UpdateQuntity(int CartId, int Quntity);
        void RemoveFromCart(int id);
    }
}
