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
    public class MaterialS : BaseService, IMaterialS
    {
        private readonly JWTSettings _jwtSettings;
        private readonly IRepository<Material> _repository = new Repository<Material>();

        public MaterialS(JWTSettings jwtSettings)
        {
            _jwtSettings = jwtSettings;
        }

        public DatatablesVM<Material> GetAll(int start, int length)
        {
            var count = _repository.GetAll().Count();
            var data = _repository.GetAll().Skip(start).Take(length);
            var result = new DatatablesVM<Material>
            {
                recordsTotal = count,
                recordsFiltered = count,
                data = data,
            };
            return result;
        }

        public Material GetById(int id)
        {
            var result = _repository.Get(c => c.Id == id);
            return result;
        }
        public void Update(Material data)
        {

           // var Material = _repository.Get(c => c.Id == data.Id);


            _repository.Update(data);

        }


        public void Create(Material data)
        {
            // TODO: Exception
 
            _repository.Create(data);
         
        }
        public void Delete(int id)
        {
            // TODO: Exception
            var Material = _repository.Get(c => c.Id == id);
            _repository.Delete(Material);
        }
    }
}
