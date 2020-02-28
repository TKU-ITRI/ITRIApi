using ITRI.Models.Entities;
using ITRI.ViewModels;


namespace ITRI.Services.Interface
{
    public interface IOrderselfmadeS
    {
        DatatablesVM<Orderselfmade> GetAll(int start, int length, int Id);
        Orderselfmade GetById(int id);

        void Update(Orderselfmade data);
        void Create(Orderselfmade data);
        void Delete(int id);
    }
}
