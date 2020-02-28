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
    public class GonS : BaseService, IGonS
    {
        private readonly JWTSettings _jwtSettings;
        private readonly IRepository<Gon> _repository = new Repository<Gon>();

        public GonS(JWTSettings jwtSettings)
        {
            _jwtSettings = jwtSettings;
        }

        public DatatablesVM<Gon> GetAll(int start, int length,int id)
        {
            var count = _repository.GetAll().Where(c=>c.PorderNo == id).Count();
            var data = _repository.GetAll().Where(c => c.PorderNo == id).Skip(start).Take(length);
            var result = new DatatablesVM<Gon>
            {
                recordsTotal = count,
                recordsFiltered = count,
                data = data,
            };

            return result;
        }

        public Gon GetById(int id)
        {
            var result = _repository.Get(c => c.Id == id);
            return result;
        }
        public void Update(Gon data)
        {

           // var Gon = _repository.Get(c => c.Id == data.Id);


            _repository.Update(data);

        }


        public int Create(Gon data)
        {
            // TODO: Exception
 
            _repository.Create(data);
            var result = _repository.GetAll().Where(c => c.PorderNo == data.PorderNo).LastOrDefault().Id;
            return result;

        }
        public void Delete(int id)
        {
            // TODO: Exception
            var Gon = _repository.Get(c => c.Id == id);
            _repository.Delete(Gon);
        }
    }
}
