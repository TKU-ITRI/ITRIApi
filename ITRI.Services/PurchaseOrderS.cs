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
    public class PurchaseOrderS : BaseService, IPurchaseOrderS
    {
        private readonly JWTSettings _jwtSettings;
        private readonly IRepository<PurchaseOrder> _repository = new Repository<PurchaseOrder>();

        public PurchaseOrderS(JWTSettings jwtSettings)
        {
            _jwtSettings = jwtSettings;
        }

        public DatatablesVM<PurchaseOrder> GetAll(int start, int length)
        {
            var count = _repository.GetAll().Count();
            var data = _repository.GetAll().Skip(start).Take(length);
            var result = new DatatablesVM<PurchaseOrder>
            {
                recordsTotal = count,
                recordsFiltered = count,
                data = data,
            };
            return result;
        }

        public PurchaseOrder GetById(int id)
        {
            var result = _repository.Get(c => c.Id == id);
            return result;
        }
        public void Update(PurchaseOrder data)
        {

           // var PurchaseOrder = _repository.Get(c => c.Id == data.Id);


            _repository.Update(data);

        }


        public void Create(PurchaseOrder data)
        {
            // TODO: Exception
 
            _repository.Create(data);
         
        }
        public void Delete(int id)
        {
            // TODO: Exception
            var PurchaseOrder = _repository.Get(c => c.Id == id);
            _repository.Delete(PurchaseOrder);
        }
    }
}
