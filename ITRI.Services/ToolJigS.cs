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
    public class ToolJigS : BaseService, IToolJigS
    {
        private readonly JWTSettings _jwtSettings;
        private readonly IRepository<Tooljig> _repository = new Repository<Tooljig>();

        public ToolJigS(JWTSettings jwtSettings)
        {
            _jwtSettings = jwtSettings;
        }

        public DatatablesVM<Tooljig> GetAll(int start, int length)
        {
            var count = _repository.GetAll().Count();
            var data = _repository.GetAll().Skip(start).Take(length);
            var result = new DatatablesVM<Tooljig>
            {
                recordsTotal = count,
                recordsFiltered = count,
                data = data,
            };
            return result;
        }

        public Tooljig GetById(int id)
        {
            var result = _repository.Get(c => c.Id == id);
            return result;
        }
        public void Update(Tooljig data)
        {

           // var ToolJig = _repository.Get(c => c.Id == data.Id);


            _repository.Update(data);

        }


        public void Create(Tooljig data)
        {
            // TODO: Exception
 
            _repository.Create(data);
         
        }
        public void Delete(int id)
        {
            // TODO: Exception
            var Tooljig = _repository.Get(c => c.Id == id);
            _repository.Delete(Tooljig);
        }
    }
}
