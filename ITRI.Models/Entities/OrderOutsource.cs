using System;
using System.Collections.Generic;

namespace ITRI.Models.Entities
{
    public partial class Orderoutsource
    {
        public int Id { get; set; }
        public string OOrderContractor { get; set; }
        public DateTimeOffset? OOrderPredictDate { get; set; }
        public DateTimeOffset? OOrderCompleteDate { get; set; }
        public string OOrderImage { get; set; }
        public string OOrderSchedule { get; set; }
        public string OOrderMethod { get; set; }
        public int? OGonNo { get; set; }
        public DateTimeOffset? CreateDate { get; set; }
        public DateTimeOffset? ModifyDate { get; set; }

        public virtual Gon OGonNoNavigation { get; set; }
    }
}
