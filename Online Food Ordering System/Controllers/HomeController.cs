using Microsoft.AspNetCore.Mvc;
using Online_Food_Ordering_System.Models;
using System.Diagnostics;

namespace Online_Food_Ordering_System.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            List<Advantage> advantages = new List<Advantage>();
            Advantage advantage1 = new Advantage { 
                title= "very high quality",
                pahpargraph= "We work hard with the latest technology\r\n                and the most skilled chefs to increase\r\n                quality and provide you with the best service",
                imge = "img/chaif.png",
                dirction=Dirction.right
                
            };

            Advantage advantage2 = new Advantage
            {
                title = "very fast delever",
                pahpargraph = "We have a team \r\nof the fastest Delivery\r\n Drivers and branches all over the world",
                imge = "img/delevary deriver.png",
                dirction = Dirction.left

            };

            Advantage advantage3 = new Advantage
            {
                title = "Be Happy",
                pahpargraph = "Our goal is to make \r\nyou happy so smile",
                imge = "img/logo_icon.png",
                dirction = Dirction.right

            };

            advantages.Add(advantage1);
            advantages.Add(advantage2);
            advantages.Add(advantage3);

            return View(advantages);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
