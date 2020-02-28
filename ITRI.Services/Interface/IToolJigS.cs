using ITRI.Models.Entities;
using ITRI.ViewModels;


namespace ITRI.Services.Interface
{
    public interface IToolJigS
    {
        DatatablesVM<Tooljig> GetAll(int start, int length);
        Tooljig GetById(int id);

        void Update(Tooljig data);
        void Create(Tooljig data);
        void Delete(int id);
    }
}
