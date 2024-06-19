using Online_Food_Ordering_SysBtem.Models;
using Online_Food_Ordering_System.Models;

namespace Online_Food_Ordering_System.Repository.abstraction_layer
{
    public interface IInvoiceRepository
    {
        List<Invoice> GetAll();
        Invoice GetById(int id);
        List<Invoice> GetWhere(Func<Invoice , bool> func);
        Invoice Insert(Invoice item);
        void Edit(Invoice item);
        void Delete(int id);
    }
}
