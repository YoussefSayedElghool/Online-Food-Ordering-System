using Online_Food_Ordering_System.Repository;
using Online_Food_Ordering_System.Service.abstraction_layer;
using Online_Food_Ordering_System.View_Models;
using System.Collections.Generic;

namespace Online_Food_Ordering_System.Service
{
    public class FoodService : IFoodService
    {
        private readonly IFoodRepository foodRepository;

        public FoodService(IFoodRepository foodRepository)
        {
            this.foodRepository = foodRepository;
        }
        public List<FoodCardVeiwModel>? GetAllFood()
        {
            List<FoodCardVeiwModel> foodCards = new List<FoodCardVeiwModel>();

            foreach (var item in foodRepository.GetAll())
            {
                FoodCardVeiwModel foodCard = new FoodCardVeiwModel()
                {
                    Name = item.Name,
                    Price = item.Price,
                    VegType = item.Veg.Type,
                    CType = item.CType.Type,
                    Image = item.Image,
                    AvargeRating = 4.5m
                };

                foodCards.Add(foodCard);
            }

            return foodCards;
        }
    }
}
