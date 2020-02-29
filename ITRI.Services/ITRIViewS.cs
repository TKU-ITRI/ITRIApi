using System;
using System.Collections.Generic;
using System.Linq;
using ITRI.Models;
using ITRI.Models.Entities;
using ITRI.Models.Helper;
using ITRI.Models.Interface;
using ITRI.Services.Interface;
using ITRI.ViewModels;
using Newtonsoft.Json.Linq;

namespace ITRI.Services
{
    public class ITRIViewS : IITRIViewS
    {
        private readonly JWTSettings _jwtSettings;
        private readonly IRepository<Views_Table> _repository = new Repository<Views_Table>();

        public ITRIViewS(JWTSettings jwtSettings)
        {
            jwtSettings = _jwtSettings;
        }
        public DatatablesVM<Views_Table> GetAll(int start, int length)
        {
            var count = _repository.Query().Count();
            var data1 = _repository.Query().Skip(start).Take(length);
            var ViewList = new List<Views_Table>();
            foreach(var d in data1)
            {
                var v = new Views_Table();
                v.gonid = d.gonid;
                ViewList.Add(v);
            }
            
            var result = new DatatablesVM<Views_Table>
            {
                recordsTotal = count,
                recordsFiltered = count,
                data = ViewList,
            };
            return result;
        }
   

    }
}
