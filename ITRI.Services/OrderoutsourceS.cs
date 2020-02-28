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
    public class OrderoutsourceS : BaseService, IOrderoutsourceS
    {
        private readonly JWTSettings _jwtSettings;
        private readonly IRepository<Orderoutsource> _repository = new Repository<Orderoutsource>();

        public OrderoutsourceS(JWTSettings jwtSettings)
        {
            _jwtSettings = jwtSettings;
        }

        public DatatablesVM<Orderoutsource> GetAll(int start, int length)
        {
            var count = _repository.GetAll().Count();
            var data = _repository.GetAll().Skip(start).Take(length);
            var result = new DatatablesVM<Orderoutsource>
            {
                recordsTotal = count,
                recordsFiltered = count,
                data = data,
            };
            return result;
        }

        public Orderoutsource GetById(int id)
        {
            var result = _repository.Get(c => c.Id == id);
            return result;
        }
        public void Update(Orderoutsource data)
        {

           // var Orderoutsource = _repository.Get(c => c.Id == data.Id);


            _repository.Update(data);

        }


        public void Create(Orderoutsource data)
        {
            // TODO: Exception
 
            _repository.Create(data);
         
        }
        public void Delete(int id)
        {
            // TODO: Exception
            var Orderoutsource = _repository.Get(c => c.Id == id);
            _repository.Delete(Orderoutsource);
        }
    }
}
