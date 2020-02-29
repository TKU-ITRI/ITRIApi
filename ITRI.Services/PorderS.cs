using System;
using ITRI.Models;
using ITRI.Models.Entities;
using ITRI.Models.Helper;
using ITRI.Models.Interface;
using ITRI.Services.Interface;
using ITRI.ViewModels;
using System.Linq;

namespace ITRI.Services
{
    public class PorderS : BaseService, IPorderS
    {
        private readonly JWTSettings _jwtSettings;
        private readonly IRepository<Porder> _repository = new Repository<Porder>();

        public PorderS(JWTSettings jwtSettings)
        {
            _jwtSettings = jwtSettings;
        }

        public DatatablesVM<Porder> GetAll(int start, int length, int accountId)
        {
            var count = _repository.GetAll().Where(c=>c.AccountId == accountId).Count();
            var data = _repository.GetAll().Where(c => c.AccountId == accountId).Skip(start).Take(length);
            var result = new DatatablesVM<Porder>
            {
                recordsTotal = count,
                recordsFiltered = count,
                data = data,
            };
            return result;
        }

        public Porder GetById(int id)
        {
            var result = _repository.Get(c => c.Id == id);
            return result;
        }
        public void Update(Porder data)
        {

           // var Porder = _repository.Get(c => c.Id == data.Id);


            _repository.Update(data);

        }


        public void Create(Porder data)
        {
            // TODO: Exception
 
            _repository.Create(data);
         
        }
        public void Delete(int id)
        {
            // TODO: Exception
            var Porder = _repository.Get(c => c.Id == id);
            _repository.Delete(Porder);
        }
    }
}
