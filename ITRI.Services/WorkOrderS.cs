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
    public class WorkOrderS : BaseService, IWorkOrderS
    {
        private readonly JWTSettings _jwtSettings;
        private readonly IRepository<WorkOrder> _repository = new Repository<WorkOrder>();

        public WorkOrderS(JWTSettings jwtSettings)
        {
            _jwtSettings = jwtSettings;
        }

        public DatatablesVM<WorkOrder> GetAll(int start, int length)
        {
            var count = _repository.GetAll().Count();
            var data = _repository.GetAll().Skip(start).Take(length);
            var result = new DatatablesVM<WorkOrder>
            {
                recordsTotal = count,
                recordsFiltered = count,
                data = data,
            };
            return result;
        }

        public WorkOrder GetById(int id)
        {
            var result = _repository.Get(c => c.Id == id);
            return result;
        }
        public void Update(WorkOrder data)
        {

           // var WorkOrder = _repository.Get(c => c.Id == data.Id);


            _repository.Update(data);

        }


        public void Create(WorkOrder data)
        {
            // TODO: Exception
 
            _repository.Create(data);
         
        }
        public void Delete(int id)
        {
            // TODO: Exception
            var WorkOrder = _repository.Get(c => c.Id == id);
            _repository.Delete(WorkOrder);
        }
    }
}