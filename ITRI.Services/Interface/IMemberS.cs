using ITRI.Models.Entities;
using ITRI.ViewModels;
using System.Collections.Generic;

namespace ITRI.Services.Interface
{
    public interface IMemberS
    {
        DatatablesVM<Member> GetAll(int start, int length, int accountId);

        IEnumerable<Member> GetAllList(int AccountId);

        Member GetById(int id);

        void Update(Member data);
        void Create(Member data);
        void Delete(int id);
    }
}
