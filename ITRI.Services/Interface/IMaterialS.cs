using ITRI.Models.Entities;
using ITRI.ViewModels;


namespace ITRI.Services.Interface
{
    public interface IMaterialS
    {
        DatatablesVM<Material> GetAll(int start, int length);
        Material GetById(int id);

        void Update(Material data);
        void Create(Material data);
        void Delete(int id);
    }
}
