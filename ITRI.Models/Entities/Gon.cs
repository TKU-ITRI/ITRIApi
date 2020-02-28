using System;
using System.Collections.Generic;

namespace ITRI.Models.Entities
{
    public partial class Gon
    {
        public Gon()
        {
            AssemblyList = new HashSet<AssemblyList>();
            Orderoutsource = new HashSet<Orderoutsource>();
            Orderselfmade = new HashSet<Orderselfmade>();
            PurchaseOrder = new HashSet<PurchaseOrder>();
        }

        public int Id { get; set; }
        public int? PorderNo { get; set; }
        public DateTimeOffset? CreateDate { get; set; }
        public DateTimeOffset? ModifyDate { get; set; }

        public virtual Porder PorderNoNavigation { get; set; }
        public virtual ICollection<AssemblyList> AssemblyList { get; set; }
        public virtual ICollection<Orderoutsource> Orderoutsource { get; set; }
        public virtual ICollection<Orderselfmade> Orderselfmade { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrder { get; set; }
    }
}
