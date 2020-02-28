using ITRI.Models.Entities;
using ITRI.ViewModels;


namespace ITRI.Services.Interface
{
    public interface IMemberS
    {
        DatatablesVM<Member> GetAll(int start, int length);
        Member GetById(int id);

        void Update(Member data);
        void Create(Member data);
        void Delete(int id);
    }
}
