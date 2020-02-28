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
            var data = _repository.Query().Skip(start).Take(length);
            var result = new DatatablesVM<Views_Table>
            {
                recordsTotal = count,
                recordsFiltered = count,
                data = data,
            };
            return result;
        }

    }
}
