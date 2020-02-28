using ITRI.Models.Entities;
using ITRI.ViewModels;


namespace ITRI.Services.Interface
{
    public interface IOrderoutsourceS
    {
        DatatablesVM<Orderoutsource> GetAll(int start, int length, int Id);
        Orderoutsource GetById(int id);

        void Update(Orderoutsource data);
        void Create(Orderoutsource data);
        void Delete(int id);
    }
}
