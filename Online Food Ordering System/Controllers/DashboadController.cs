using Humanizer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Online_Food_Ordering_System.Models;
using Online_Food_Ordering_System.Service.abstraction_layer;
using Online_Food_Ordering_System.View_Models;

namespace Online_Food_Ordering_System.Controllers
{
    public class DashboadController : Controller
    {

        public DashboadController()
        {
        }


        [HttpGet]
        public IActionResult Statistics()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Orders()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FoodEdit()
        {
            return View();
        }


    }
}
