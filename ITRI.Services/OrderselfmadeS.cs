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
    public class OrderselfmadeS : BaseService, IOrderselfmadeS
    {
        private readonly JWTSettings _jwtSettings;
        private readonly IRepository<Orderselfmade> _repository = new Repository<Orderselfmade>();

        public OrderselfmadeS(JWTSettings jwtSettings)
        {
            _jwtSettings = jwtSettings;
        }

        public DatatablesVM<Orderselfmade> GetAll(int start, int length,int Id)
        {
            var count = _repository.GetAll().Where(c => c.SGonNo == Id).Count();
            var data = _repository.GetAll().Where(c => c.SGonNo == Id).Skip(start).Take(length);
            var result = new DatatablesVM<Orderselfmade>
            {
                recordsTotal = count,
                recordsFiltered = count,
                data = data,
            };
            return result;
        }

        public Orderselfmade GetById(int id)
        {
            var result = _repository.Get(c => c.Id == id);
            return result;
        }
        public void Update(Orderselfmade data)
        {

           // var Orderselfmade = _repository.Get(c => c.Id == data.Id);


            _repository.Update(data);

        }


        public void Create(Orderselfmade data)
        {
            // TODO: Exception
 
            _repository.Create(data);
         
        }
        public void Delete(int id)
        {
            // TODO: Exception
            var Orderselfmade = _repository.Get(c => c.Id == id);
            _repository.Delete(Orderselfmade);
        }
    }
}
