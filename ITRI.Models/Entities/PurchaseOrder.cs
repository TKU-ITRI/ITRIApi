using System;
using System.Collections.Generic;

namespace ITRI.Models.Entities
{
    public partial class PurchaseOrder
    {
        public int Id { get; set; }
        public string PurchaseOrderList { get; set; }
        public int? PurchaseOrderMemberName { get; set; }
        public DateTimeOffset? PurchaseOrderPredictDate { get; set; }
        public DateTimeOffset? PurchaseOrderCompleteDate { get; set; }
        public int? PGonNo { get; set; }
        public DateTimeOffset? CreateDate { get; set; }
        public DateTimeOffset? ModifyDate { get; set; }

        public virtual Gon PGonNoNavigation { get; set; }
    }
}
