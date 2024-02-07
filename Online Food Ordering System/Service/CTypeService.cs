using Online_Food_Ordering_System.Models;
using Online_Food_Ordering_System.Repository.abstraction_layer;
using Online_Food_Ordering_System.Service.abstraction_layer;
using Online_Food_Ordering_System.Views;

namespace Online_Food_Ordering_System.Service
{
    public class CTypeService : ICTypeService
    {
        private readonly ICTypeRepository cTypeRepository;

        public CTypeService(ICTypeRepository cTypeRepository)
        {
            this.cTypeRepository = cTypeRepository;
        }

        public List<CType> GetAllCType()
        {
            return cTypeRepository.GetAll();
        }

        public CTypeFilterViewModel GetAllCType(int id)
        {
            CTypeFilterViewModel cTypeFilterViewModel = new CTypeFilterViewModel()
            {
                cTypes = cTypeRepository.GetAll(),
                SelectedTypeId = id
            };

            return cTypeFilterViewModel;
        }
    }
}
