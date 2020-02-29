using System;
using System.Collections.Generic;
using System.Linq;
using ITRI.Models;
using ITRI.Models.Entities;
using ITRI.Models.Helper;
using ITRI.Models.Interface;
using ITRI.Services.Interface;
using ITRI.ViewModels;
using Newtonsoft.Json.Linq;

namespace ITRI.Services
{
    public class CompanyManageS : ICompanyManageS
    {
        private readonly JWTSettings _jwtSettings;
        private readonly IRepository<Company> _repository = new Repository<Company>();
        private readonly IRepository<Account> _account = new Repository<Account>();

        public CompanyManageS(JWTSettings jwtSettings)
        {
            jwtSettings = _jwtSettings;
        }
        public DatatablesVM<Company> GetAll(int start, int length)
        {
            var count = _repository.GetAll().Count();
            var data = _repository.GetAll().Skip(start).Take(length);
            var result = new DatatablesVM<Company>
            {
                recordsTotal = count,
                recordsFiltered = count,
                data = data,
            };
            return result;
        }

        public IEnumerable<Company> GetAllCompany()
        {
            var result = _repository.GetAll();
            return result;
        }
        public DatatablesVM<Account> GetAllAccount(int start, int length, int CompanyId)
        {
            var count = _account.GetAll().Where(c => c.CompanyId == CompanyId).Count();
            var data = _account.GetAll().Where(c => c.CompanyId == CompanyId).Skip(start).Take(length);
            var result = new DatatablesVM<Account>
            {
                recordsTotal = count,
                recordsFiltered = count,
                data = data,
            };
            return result;
        }

        public DatatablesVM<Account> GetAllSAccount(int start, int length, int CompanyId)
        {
            var count = _account.GetAll().Where(c => c.CompanyId == CompanyId && c.Type == "S").Count();
            var data = _account.GetAll().Where(c => c.CompanyId == CompanyId && c.Type == "S").Skip(start).Take(length);
            var result = new DatatablesVM<Account>
            {
                recordsTotal = count,
                recordsFiltered = count,
                data = data,
            };
            return result;
        }
        public Company GetById(int id)
        {
            var company = _repository.Get(c => c.Id == id);
            return company;
        }
        public void Update(Company data)
        {
            _repository.Update(data);

        }


        public void Create(Company data)
        {
            // TODO: Exception
            _repository.Create(data);
        }
        public void Delete(int id)
        {
            // TODO: Exception
            var company = _repository.Get(c => c.Id == id);
            _repository.Delete(company);
        }

        public void TurnStatus(int id)
        {
            var company = _repository.Get(c => c.Id == id);
            //company.Status = (company.Status == 0) ? Convert.ToByte(1) : Convert.ToByte(0);
            var result = company.Active;
            _repository.Update(company);


        }



    }
}
