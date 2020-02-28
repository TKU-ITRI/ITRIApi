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
    public class AssemblyListS : BaseService, IAssemblyListS
    {
        private readonly JWTSettings _jwtSettings;
        private readonly IRepository<AssemblyList> _repository = new Repository<AssemblyList>();

        public AssemblyListS(JWTSettings jwtSettings)
        {
            _jwtSettings = jwtSettings;
        }

        public DatatablesVM<AssemblyList> GetAll(int start, int length,int Id)
        {
            var count = _repository.GetAll().Where(c=>c.AGonNo==Id).Count();
            var data = _repository.GetAll().Where(c => c.AGonNo == Id).Skip(start).Take(length);
            var result = new DatatablesVM<AssemblyList>
            {
                recordsTotal = count,
                recordsFiltered = count,
                data = data,
            };
            return result;
        }

        public AssemblyList GetById(int id)
        {
            var result = _repository.Get(c => c.Id == id);
            return result;
        }
        public void Update(AssemblyList data)
        {

           // var AssemblyList = _repository.Get(c => c.Id == data.Id);


            _repository.Update(data);

        }


        public void Create(AssemblyList data)
        {
            // TODO: Exception
 
            _repository.Create(data);
         
        }
        public void Delete(int id)
        {
            // TODO: Exception
            var AssemblyList = _repository.Get(c => c.Id == id);
            _repository.Delete(AssemblyList);
        }
    }
}
