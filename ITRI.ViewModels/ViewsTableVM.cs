//using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITRI.ViewModels
{
    public class ViewsTableVM
    {
        public int? porderid { get; set; }
        public int? client_No { get; set; }
        public int? order_No { get; set; }
        public DateTimeOffset? order_CreateDate { get; set; }
        public DateTimeOffset? order_Predict_Date { get; set; }
        public int? gonid { get; set; }
        public int? purchase_Id { get; set; }
        public int? assembly_Id { get; set; }
        public int? orderoutsource_Id { get; set; }
        public int? orderselfmade_Id { get; set; }

        public int orderrowspan { get; set; }
        public int clientrowspan { get; set; }
        public int gonrowspan { get; set; }
    }
}
