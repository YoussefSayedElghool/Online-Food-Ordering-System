using Online_Food_Ordering_System.Models;
using Online_Food_Ordering_System.Repository.abstraction_layer;

namespace Online_Food_Ordering_System.Repository
{
    public class CTypeRepository : ICTypeRepository
    {

        AppDbContext context;
        public CTypeRepository(AppDbContext _context)
        {
            context = _context;
        }

        public List<CType> GetAll()
        {
            return context.CTypes.ToList();
        }
        public CType GetById(int id)
        {
            return context.CTypes.FirstOrDefault(x => x.CTypeId == id);
        }

        public void Insert(CType item)
        {
            context.CTypes.Add(item);
            context.SaveChanges();
        }

        public void Edit(CType item)
        {
            context.Update(item);
            context.SaveChanges();

        }

        public void Delete(int id)
        {
            CType old = GetById(id);
            context.CTypes.Remove(old);
            context.SaveChanges();
        }

    }
}

