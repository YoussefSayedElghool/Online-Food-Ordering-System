using Online_Food_Ordering_System.Models;
using Online_Food_Ordering_System.Repository.abstraction_layer;

namespace Online_Food_Ordering_System.Repository
{
    public class VegTypeRepository : IVegTypeRepository
    {

        AppDbContext context;
        public VegTypeRepository(AppDbContext _context)
        {
            context = _context;
        }

        public List<Veg> GetAll()
        {
            return context.Vegs.ToList();
        }
        public Veg GetById(int id)
        {
            return context.Vegs.FirstOrDefault(x => x.VegId== id);
        }

        public void Insert(Veg item)
        {
            context.Vegs.Add(item);
            context.SaveChanges();
        }

        public void Edit(Veg item)
        {
            context.Update(item);
            context.SaveChanges();

        }

        public void Delete(int id)
        {
            Veg old = GetById(id);
            context.Vegs.Remove(old);
            context.SaveChanges();
        }
    }
}

