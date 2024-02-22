using Online_Food_Ordering_System.Models;
using System.Security.Principal;

namespace Online_Food_Ordering_System.Repository
{
    public class FoodRepository : IFoodRepository
    {
        AppDbContext context;
        public FoodRepository(AppDbContext _context)
        {
            context = _context;
        }

        public FoodRepository()
        {
        }

        public List<Food> GetAll()
        {
            return context.Foods.Where(f => f.IsVisible).ToList();
        }
        public Food GetById(int id)
        {
            return context.Foods.FirstOrDefault(x => x.FoodId == id);
        }

        public void Insert(Food item)
        {
            context.Foods.Add(item);
            context.SaveChanges();
        }

        public void Edit(Food item)
        {
            context.Update(item);
            context.SaveChanges();

        }

        public void Delete(int id)
        {
            Food old = GetById(id);
            context.Foods.Remove(old);
            context.SaveChanges();
        }
        public List<Food> GetByCTypeId(int id)
        {
            return context.Foods.Where(x => x.CTypeId == id).ToList();
        }
    }
}