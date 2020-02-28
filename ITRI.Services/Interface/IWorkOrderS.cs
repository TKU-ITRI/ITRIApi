using ITRI.Models.Entities;
using ITRI.ViewModels;


namespace ITRI.Services.Interface
{
    public interface IWorkOrderS
    {
        DatatablesVM<WorkOrder> GetAll(int start, int length);
        WorkOrder GetById(int id);

        void Update(WorkOrder data);
        void Create(WorkOrder data);
        void Delete(int id);
    }
}
