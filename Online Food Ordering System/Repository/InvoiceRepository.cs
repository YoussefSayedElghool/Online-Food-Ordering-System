using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Online_Food_Ordering_SysBtem.Models;
using Online_Food_Ordering_System.Models;
using Online_Food_Ordering_System.Repository.abstraction_layer;

namespace Online_Food_Ordering_System.Repository
{
    public class InvoiceRepository : IInvoiceRepository
    {

        AppDbContext context;
        public InvoiceRepository(AppDbContext _context)
        {
            context = _context;
        }

        public List<Invoice> GetAll()
        {
            return context.Invoices.ToList();
        }
        public Invoice GetById(int id)
        {
            return context.Invoices.FirstOrDefault(x => x.InvoiceId== id);
        }

        public Invoice Insert(Invoice item)
        {
            EntityEntry<Invoice> invoice = context.Invoices.Add(item);           
            context.SaveChanges();
            return item;
        }

        public void Edit(Invoice item)
        {
                context.Invoices.Update(item);
                context.SaveChanges();
        }

        public void Delete(int id)
        {
            Invoice old = GetById(id);
            context.Invoices.Remove(old);
            context.SaveChanges();
        }

        public List<Invoice> GetWhere(Func<Invoice, bool> func)
        {
            return context.Invoices.Where(func.Invoke).ToList();
        }
    }
}

