using Humanizer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Online_Food_Ordering_System.Models;
using Online_Food_Ordering_System.Repository;
using Online_Food_Ordering_System.Repository.abstraction_layer;
using Online_Food_Ordering_System.Service.abstraction_layer;
using Online_Food_Ordering_System.View_Models;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Security.Claims;

namespace Online_Food_Ordering_System.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly ICartService cartService;
        private readonly ICheckoutRepository checkoutRepository;

        public CheckoutController(ICartService cartService , ICheckoutRepository checkoutRepository)
        {
            this.cartService = cartService;
            this.checkoutRepository = checkoutRepository;
        }


        [HttpGet]
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(string paymentMethod)
        {
            if (paymentMethod == "offline")
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                checkoutRepository.MakeOrder(userId);
            }
            return View();
        }

    }
}
