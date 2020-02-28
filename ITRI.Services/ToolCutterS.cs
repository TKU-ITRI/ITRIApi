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
    public class ToolCutterS : BaseService, IToolCutterS
    {
        private readonly JWTSettings _jwtSettings;
        private readonly IRepository<Toolcutter> _repository = new Repository<Toolcutter>();

        public ToolCutterS(JWTSettings jwtSettings)
        {
            _jwtSettings = jwtSettings;
        }

        public DatatablesVM<Toolcutter> GetAll(int start, int length)
        {
            var count = _repository.GetAll().Count();
            var data = _repository.GetAll().Skip(start).Take(length);
            var result = new DatatablesVM<Toolcutter>
            {
                recordsTotal = count,
                recordsFiltered = count,
                data = data,
            };
            return result;
        }

        public Toolcutter GetById(int id)
        {
            var result = _repository.Get(c => c.Id == id);
            return result;
        }
        public void Update(Toolcutter data)
        {

           // var Toolcutter = _repository.Get(c => c.Id == data.Id);


            _repository.Update(data);

        }


        public void Create(Toolcutter data)
        {
            // TODO: Exception
 
            _repository.Create(data);
         
        }
        public void Delete(int id)
        {
            // TODO: Exception
            var Toolcutter = _repository.Get(c => c.Id == id);
            _repository.Delete(Toolcutter);
        }
    }
}
