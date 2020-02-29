using ITRI.Models.Entities;
using ITRI.ViewModels;


namespace ITRI.Services.Interface
{
    public interface IToolCutterS
    {
        DatatablesVM<Toolcutter> GetAll(int start, int length, int accountId);
        Toolcutter GetById(int id);

        void Update(Toolcutter data);
        void Create(Toolcutter data);
        void Delete(int id);
    }
}
