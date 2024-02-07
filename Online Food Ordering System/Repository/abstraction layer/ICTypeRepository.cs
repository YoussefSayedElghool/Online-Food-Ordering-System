using Online_Food_Ordering_System.Models;

namespace Online_Food_Ordering_System.Repository.abstraction_layer
{
    public interface ICTypeRepository
    {
        List<CType> GetAll();
        CType GetById(int id);
        void Insert(CType item);
        void Edit(CType item);
        void Delete(int id);
    }
}
