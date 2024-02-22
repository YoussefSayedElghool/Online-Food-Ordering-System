using Online_Food_Ordering_System.Models;
using Online_Food_Ordering_System.Repository;
using Online_Food_Ordering_System.Repository.abstraction_layer;
using Online_Food_Ordering_System.Service.abstraction_layer;
using Online_Food_Ordering_System.View_Models;
using System.Collections.Generic;
using static Online_Food_Ordering_System.Models.UploadUtility;

namespace Online_Food_Ordering_System.Service
{
    public class FoodService : IFoodService
    {
        private readonly IFoodRepository foodRepository;
        private readonly ICTypeRepository cTypeRepository;
        private readonly IVegTypeRepository vegTypeRepository;
        private readonly IConfiguration configuration;

        public FoodService(IFoodRepository foodRepository, ICTypeRepository cTypeRepository, IVegTypeRepository vegTypeRepository, IConfiguration configuration)
        {
            this.foodRepository = foodRepository;
            this.cTypeRepository = cTypeRepository;
            this.vegTypeRepository = vegTypeRepository;
            this.configuration = configuration;
        }


        public void Delete(int id)
        {
            foodRepository.Delete(id);
        }

        public void Edit(Food item)
        {
            foodRepository.Edit(item);
        }

        public List<FoodCardVeiwModel>? GetAllFood()
        {
            List<FoodCardVeiwModel> foodCards = new List<FoodCardVeiwModel>();

            foreach (var item in foodRepository.GetAll())
            {
                FoodCardVeiwModel foodCard = new FoodCardVeiwModel()
                {
                    FoodId = item.FoodId,
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

        public List<FoodCardVeiwModel>? GetByCTypeId(int id)
        {
            List<FoodCardVeiwModel> foodCards = new List<FoodCardVeiwModel>();

            foreach (var item in foodRepository.GetByCTypeId(id))
            {
                FoodCardVeiwModel foodCard = new FoodCardVeiwModel()
                {
                    FoodId = item.FoodId,
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

        public Food GetById(int id)
        {
            return foodRepository.GetById(id);
        }

        public void Insert(Food item)
        {
            foodRepository.Insert(item);
        }


        public Food CreateFood(FoodForm foodForm)
        {
            Food food = new Food()
            {
                FoodId = foodForm.FoodId,
                Name = foodForm.Name,
                Description = foodForm.Description,
                Price = foodForm.Price,
                CTypeId = foodForm.CTypeId,
                VegId = foodForm.VegId,
                IsVisible = foodForm.IsVisible,
                Image = foodForm.ImageSrc

            };

            if (foodForm.ImageFile != null)
            {
                UploadOperationResult Result = UploadImage(foodForm.ImageFile, configuration["RootUploadImagePath"], configuration["SuperFolderUploadImage"]);

                if (!Result.IsSuccess) throw new Exception("Erorr happend when image upload");
                food.Image = Result.RelastivePath;
            }
            return food;
        }

        public FoodForm InitializedFoodFormWithData()
        {
            FoodForm addFoodViewModel = new FoodForm()
            {
                CTypes = cTypeRepository.GetAll(),
                Vegs = vegTypeRepository.GetAll()
            };

            return addFoodViewModel;
        }

        public FoodForm InitializedFoodFormWithData(Food food)
        {

            FoodForm addFoodViewModel = new FoodForm()
            {
                FoodId = food.FoodId,
                Name = food.Name,
                Price = food.Price,
                CTypeId = food.CTypeId,
                VegId = food.VegId,
                Description = food.Description,
                ImageSrc = food.Image,
                CTypes = cTypeRepository.GetAll(),
                Vegs = vegTypeRepository.GetAll()
            };

            return addFoodViewModel;
        }

    }
}
