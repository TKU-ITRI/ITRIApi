using System;
using System.Collections.Generic;

namespace ITRI.Models.Entities
{
    public partial class Porder
    {
        public Porder()
        {
            Gon = new HashSet<Gon>();
        }

        public int Id { get; set; }
        public int? POutOrderId { get; set; }
        public int? PInOrderId { get; set; }
        public int? POrderClientNo { get; set; }
        public DateTimeOffset? POrderPredictDate { get; set; }
        public DateTimeOffset? POrderCompleteDate { get; set; }
        public DateTimeOffset? CreateDate { get; set; }
        public DateTimeOffset? ModifyDate { get; set; }

        public virtual ICollection<Gon> Gon { get; set; }
    }
}
