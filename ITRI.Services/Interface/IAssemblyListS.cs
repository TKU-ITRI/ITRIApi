using ITRI.Models.Entities;
using ITRI.ViewModels;


namespace ITRI.Services.Interface
{
    public interface IAssemblyListS
    {
        DatatablesVM<AssemblyList> GetAll(int start, int length,int Id);
        AssemblyList GetById(int id);

        void Update(AssemblyList data);
        void Create(AssemblyList data);
        void Delete(int id);
    }
}
