using Humanizer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Online_Food_Ordering_System.Models;
using Online_Food_Ordering_System.Service.abstraction_layer;
using Online_Food_Ordering_System.View_Models;

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




        [HttpGet]
        public IActionResult UpdateFoodForm(int id)
        {
            Food food = foodService.GetById(id);
            return View(foodService.InitializedFoodFormWithData(food));
        }

        [HttpPost]
        public IActionResult UpdateFoodForm(FoodForm foodForm)
        {

            if (!ModelState.IsValid) return RedirectToAction("UpdataFood", "Food");

            try
            {
                foodService.Edit(foodService.CreateFood(foodForm));
                //return RedirectToAction("UpdataFood", "Food");
                return RedirectToAction("UpdataFood", "Food" , fragment : $"{foodForm.FoodId}");
            }
            catch (Exception)
            {

                ModelState.AddModelError("", "there are Error happened, please review the content and internet connection and try again");
                return View(foodForm);
            }
        }



        [HttpGet]
        public IActionResult AddFood()
        {
            return View(foodService.InitializedFoodFormWithData());
        }

        [HttpPost]
        public IActionResult AddFood(FoodForm foodForm)
        {

            if (!ModelState.IsValid) return RedirectToAction("AddFood");

            try
            {
                foodService.Insert(foodService.CreateFood(foodForm));
                return RedirectToAction("AddFood");
            }
            catch (Exception)
            {

                ModelState.AddModelError("", "there are Error happened, please review the content and internet connection and try again");
                return View(foodForm);
            }
        }



    }
}
