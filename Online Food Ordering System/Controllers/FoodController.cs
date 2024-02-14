using Microsoft.AspNetCore.Mvc;
using Online_Food_Ordering_System.Models;
using Online_Food_Ordering_System.Service.abstraction_layer;

namespace Online_Food_Ordering_System.Controllers
{
    public class FoodController : Controller
    {
        private readonly IFoodService foodService;

        public FoodController(IFoodService foodService)
        {
            this.foodService = foodService;
        }
        [HttpGet]
        public IActionResult UpdataFood()
        {
            return View(foodService.GetAllFood());
        }        
        
        [HttpPost]
        public IActionResult UpdataFood(int id)
        {
           Food food = foodService.GetById(id);
            foodService.Edit(food);
            return RedirectToAction("");
        }        
        
        [HttpGet]
        public IActionResult AddFood()
        {
                return View();
        }

         [HttpPost]
        public IActionResult AddFood(Food food)
        {
            if (!ModelState.IsValid)
            {
                return View(food);
            }
            else {

                try
                {
                    foodService.Insert(food);
                    return RedirectToAction("AddFood");
                }
                catch (Exception)
                {

                    ModelState.AddModelError("", "there are Error happened, please review the content and internet connection and try again");
                    return View(food);
                }
            }


           

        }


    }
}
