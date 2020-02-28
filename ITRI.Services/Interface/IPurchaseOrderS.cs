using ITRI.Models.Entities;
using ITRI.ViewModels;


namespace ITRI.Services.Interface
{
    public interface IPurchaseOrderS
    {
        DatatablesVM<PurchaseOrder> GetAll(int start, int length, int Id);
        PurchaseOrder GetById(int id);

        void Update(PurchaseOrder data);
        void Create(PurchaseOrder data);
        void Delete(int id);
    }
}
