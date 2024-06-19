using Online_Food_Ordering_System.Models;
using Online_Food_Ordering_System.Repository;
using Online_Food_Ordering_System.Repository.abstraction_layer;
using Online_Food_Ordering_System.Service.abstraction_layer;
using Online_Food_Ordering_System.View_Models;
using System.Collections.Generic;
using static Online_Food_Ordering_System.Models.UploadUtility;

namespace Online_Food_Ordering_System.Service
{
    public class CartService : ICartService
    {
        private readonly ICartRepository cartRepository;

        public CartService(ICartRepository cartRepository)
        {
            this.cartRepository = cartRepository;
        }


        public void RemoveFromCart(int id)
        {
            cartRepository.Delete(id);
        }

        public void UpdateQuntity(int CartId, int Quntity)
        {
            Cart cart = cartRepository.GetById(CartId);
            cart.Quntity = Quntity;
            cartRepository.Edit(cart);
        }

        public List<CartItemVeiwModel>? GetAllFoodAtCartByUserId(string userId)
        {
            List<Cart> Carts = cartRepository.GetByUserId(userId);
            List<CartItemVeiwModel> cartItemVeiwModels = new List<CartItemVeiwModel>();


            foreach (Cart cart in Carts)
            {
                CartItemVeiwModel cartItemVeiwModel = new CartItemVeiwModel()
                {
                    CartId = cart.CartId,
                    FoodId = cart.FoodId,
                    Image = cart.Food.Image,
                    Name = cart.Food.Name,
                    Price = cart.Food.Price,
                    Quntity = cart.Quntity

                };
                cartItemVeiwModels.Add(cartItemVeiwModel);
            }

            return cartItemVeiwModels;
        }

        public Cart GetById(int id)
        {
            return cartRepository.GetById(id);
        }

        public void AddToCart(int foodId , string userId)
        {
            Cart cart = new Cart()
            {
                FoodId = foodId,
                UserId = userId,
            };

            cartRepository.Insert(cart);

        }

        
    }
}
