using System;
using System.Collections.Generic;

namespace ITRI.Models.Entities
{
    public partial class Tooljig
    {
        public int Id { get; set; }
        public byte? OrderId { get; set; }
        public byte? MemberId { get; set; }
        public string JigClass { get; set; }
        public string JigName { get; set; }
        public int? JigNo { get; set; }
        public string JigBrand { get; set; }
        public string JigSize { get; set; }
        public byte? JigStatus { get; set; }
        public DateTimeOffset? JigUsingTime { get; set; }
        public DateTimeOffset? JigEndingTime { get; set; }
        public DateTimeOffset? JigTableCreateDate { get; set; }
        public DateTimeOffset? JigTableModifyDate { get; set; }
        public string JigUse { get; set; }
        public int? AccountId { get; set; }
        public int? CompanyId { get; set; }
    }
}
