using Humanizer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Online_Food_Ordering_System.Models;
using Online_Food_Ordering_System.Repository;
using Online_Food_Ordering_System.Repository.abstraction_layer;
using Online_Food_Ordering_System.Service.abstraction_layer;
using Online_Food_Ordering_System.View_Models;
using System.Collections.Generic;
using System.Security.Claims;

namespace Online_Food_Ordering_System.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService cartService;

        public CartController(ICartService cartService)
        {
            this.cartService = cartService;
        }


        [HttpGet]
        public IActionResult Items()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return View("Cart" , cartService.GetAllFoodAtCartByUserId(userId));
        }

        [HttpPost]
        public IActionResult Add(int foodId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            cartService.AddToCart(foodId , userId);
            return RedirectToAction("index" , "home" , fragment: $"{foodId}");
        }

        public IActionResult Update(int CartId, int Quntity)
        {
            cartService.UpdateQuntity(CartId , Quntity);
            return RedirectToAction("Items");
        }

        [HttpPost]
        public IActionResult Remove(int CartId)
        {
            cartService.RemoveFromCart(CartId);
            return RedirectToAction("Items");
        }





    }
}
