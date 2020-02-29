using ITRI.Models.Entities;
using ITRI.ViewModels;


namespace ITRI.Services.Interface
{
    public interface IPorderS
    {
        DatatablesVM<Porder> GetAll(int start, int length, int accountId);
        Porder GetById(int id);

        void Update(Porder data);
        void Create(Porder data);
        void Delete(int id);
    }
}
