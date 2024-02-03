using Online_Food_Ordering_System.Models;
using Online_Food_Ordering_System.Repository.abstraction_layer;

namespace Online_Food_Ratinging_System.Repository
{
    public class RatingRepository : IRatingRepository
    {
        AppDbContext context;
        public RatingRepository(AppDbContext _context)
        {
            context = _context;
        }

        public List<Rating> GetAll()
        {
            return context.Ratings.ToList();
        }
        public Rating GetById(int id)
        {
            return context.Ratings.FirstOrDefault(x => x.RatingId == id);
        }

        public void Insert(Rating item)
        {
            context.Ratings.Add(item);
            context.SaveChanges();
        }

        public void Edit(Rating item)
        {
            context.Update(item);
            context.SaveChanges();

        }

        public void Delete(int id)
        {
            Rating old = GetById(id);
            context.Ratings.Remove(old);
            context.SaveChanges();
        }

    }
}
