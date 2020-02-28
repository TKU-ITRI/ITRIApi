using System;
using System.Collections.Generic;

namespace ITRI.Models.Entities
{
    public partial class WorkOrder
    {
        public int Id { get; set; }
        public string OrderImage { get; set; }
        public string OrderSchedule { get; set; }
        public string OrderMethod { get; set; }
        public byte? OrderMade { get; set; }
    }
}
