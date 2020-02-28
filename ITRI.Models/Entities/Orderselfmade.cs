using System;
using System.Collections.Generic;

namespace ITRI.Models.Entities
{
    public partial class Orderselfmade
    {
        public int Id { get; set; }
        public int? SOrderMemberName { get; set; }
        public int? SOrderMachine { get; set; }
        public int? SOrderTool { get; set; }
        public string SOrderProgram { get; set; }
        public string SOrderSetting { get; set; }
        public int? SOrderCount { get; set; }
        public int? SOrderMaterial { get; set; }
        public DateTimeOffset? SOrderPredictDate { get; set; }
        public DateTimeOffset? SOrderCompleteDate { get; set; }
        public string SOrderImage { get; set; }
        public string SOrderSchedule { get; set; }
        public string SOrderMethod { get; set; }
        public int? SGonNo { get; set; }
        public DateTimeOffset? CreateDate { get; set; }
        public DateTimeOffset? ModifyDate { get; set; }

        public virtual Gon SGonNoNavigation { get; set; }
    }
}
