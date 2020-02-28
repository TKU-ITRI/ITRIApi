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
    public class MachineS : BaseService, IMachineS
    {
        private readonly JWTSettings _jwtSettings;
        private readonly IRepository<Machine> _repository = new Repository<Machine>();

        public MachineS(JWTSettings jwtSettings)
        {
            _jwtSettings = jwtSettings;
        }

        public DatatablesVM<Machine> GetAll(int start, int length)
        {
            var count = _repository.GetAll().Count();
            var data = _repository.GetAll().Skip(start).Take(length);
            var result = new DatatablesVM<Machine>
            {
                recordsTotal = count,
                recordsFiltered = count,
                data = data,
            };
            return result;
        }

        public Machine GetById(int id)
        {
            var result = _repository.Get(c => c.Id == id);
            return result;
        }
        public void Update(Machine data)
        {

           // var Machine = _repository.Get(c => c.Id == data.Id);


            _repository.Update(data);

        }


        public void Create(Machine data)
        {
            // TODO: Exception
 
            _repository.Create(data);
         
        }
        public void Delete(int id)
        {
            // TODO: Exception
            var Machine = _repository.Get(c => c.Id == id);
            _repository.Delete(Machine);
        }
    }
}
