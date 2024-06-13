using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Online_Food_Ordering_System.Models;
using Online_Food_Ordering_System.Service.abstraction_layer;
using Online_Food_Ordering_System.Views;
using System.CodeDom;
using System.Diagnostics;

namespace Online_Food_Ordering_System.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IFoodService foodService;
        private readonly ICTypeService cTypeService;

        public HomeController(IFoodService foodService , ICTypeService cTypeService)
        {
            this.foodService = foodService;
            this.cTypeService = cTypeService;
        }

        public IActionResult Index(int id)
        {
            ViewBag.Filler = cTypeService.GetAllCType(id);
            if (id == 0)
            {
                return View(foodService.GetAllFood());

            }
            else {
                return View(foodService.GetByCTypeId(id));
            }

        }



        public IActionResult AboutUs()
        {
            List<Advantage> advantages = new List<Advantage>();
            Advantage advantage1 = new Advantage { 
                title= "very high quality",
                pahpargraph= "We work hard with the latest technology\r\n                and the most skilled chefs to increase\r\n                quality and provide you with the best service",
                imge = "Images/chaif.png",
                dirction=Dirction.right
                
            };

            Advantage advantage2 = new Advantage
            {
                title = "very fast delever",
                pahpargraph = "We have a team \r\nof the fastest Delivery\r\n Drivers and branches all over the world",
                imge = "Images/delevary deriver.png",
                dirction = Dirction.left

            };

            Advantage advantage3 = new Advantage
            {
                title = "Be Happy",
                pahpargraph = "Our goal is to make \r\nyou happy so smile",
                imge = "Images/logo_icon.png",
                dirction = Dirction.right

            };

            advantages.Add(advantage1);
            advantages.Add(advantage2);
            advantages.Add(advantage3);

            return View(advantages);
        }

    }
}
