using ITRI.Models.Entities;
using ITRI.ViewModels;


namespace ITRI.Services.Interface
{
    public interface IMachineS
    {
        DatatablesVM<Machine> GetAll(int start, int length, int accountId);
        Machine GetById(int id);

        void Update(Machine data);
        void Create(Machine data);
        void Delete(int id);
    }
}
