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
        
        public DatatablesVM<ViewsTableVM> GetAll(int start, int length)
        {
            var count = _repository.Query().Count();
            
            var datal = _repository.Query().Skip(start).Take(length);
            var ViewList = new List<ViewsTableVM>();
            var a=0;
            var b = 0;
            var x = 0;
            var y = 0;
            var q = 0;
            var p = 0;
            foreach (var d in datal)
            {
                var v = new ViewsTableVM();
                
                v.gonid = d.gonid;
                v.client_No = d.client_No;
                v.order_No = d.order_No;
                v.porderid = d.porderid;
                v.order_CreateDate = d.order_CreateDate;
                v.order_Predict_Date = d.order_Predict_Date;
                v.assembly_Id = d.assembly_Id;
                v.orderoutsource_Id = d.orderoutsource_Id;
                v.orderselfmade_Id = d.orderselfmade_Id;
                if (a == d.porderid)
                {
                    b++;
                    v.orderrowspan = b;
                }
                else
                {
                    a = Convert.ToInt32(d.porderid);
                    b = 0;
                }
                if (x == d.client_No)
                {
                    y++;
                    v.clientrowspan = y;
                }
                else
                {
                    x = Convert.ToInt32(d.client_No);
                    y = 0;
                }
                if (q == d.porderid)
                {
                    p++;
                    v.gonrowspan = p;
                }
                else
                {
                    q = Convert.ToInt32(d.gonid);
                    p = 0;
                }

                ViewList.Add(v);
            }
            
            var result = new DatatablesVM<ViewsTableVM>
            {
                recordsTotal = count,
                recordsFiltered = count,
                data = ViewList,

            };
           
            return result;
        }

    }
}
