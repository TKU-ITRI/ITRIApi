using ITRI.Models.Entities;
using ITRI.ViewModels;


namespace ITRI.Services.Interface
{
    public interface IGonS
    {
        DatatablesVM<Gon> GetAll(int start, int length,int id);
        Gon GetById(int id);

        void Update(Gon data);
        int Create(Gon data);
        void Delete(int id);
    }
}
