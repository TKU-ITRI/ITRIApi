using System;
using System.Collections.Generic;

namespace ITRI.Models.Entities
{
    public partial class Toolcutter
    {
        public int Id { get; set; }
        public byte? OrderId { get; set; }
        public byte? MemberId { get; set; }
        public string CutterClass { get; set; }
        public string CutterName { get; set; }
        public int? CutterNo { get; set; }
        public string CutterBrand { get; set; }
        public string CutterSize { get; set; }
        public byte? CutterStatus { get; set; }
        public DateTimeOffset? CutterUsingTime { get; set; }
        public DateTimeOffset? CutterEndingTime { get; set; }
        public DateTimeOffset? CutterTableCreateDate { get; set; }
        public DateTimeOffset? CutterTableModifyDate { get; set; }
        public int? AccountId { get; set; }
        public int? CompanyId { get; set; }
    }
}
