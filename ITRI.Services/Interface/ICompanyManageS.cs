using System.Collections.Generic;
using ITRI.Models.Entities;
using ITRI.ViewModels;
using Newtonsoft.Json.Linq;

namespace ITRI.Services.Interface
{
    public interface ICompanyManageS
    {
        DatatablesVM<Company> GetAll(int start, int length);
        IEnumerable<Company> GetAllCompany();
        
        DatatablesVM<Account> GetAllAccount(int start, int length, int CompanyId);
        DatatablesVM<Account> GetAllSAccount(int start, int length, int CompanyId);

        Company GetById(int id);
        void Update(Company data);
        void Create(Company data);
        void Delete(int id);
        void TurnStatus(int id);
    }
}
