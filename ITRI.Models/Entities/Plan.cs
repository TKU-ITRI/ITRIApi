using System;
using System.Collections.Generic;

namespace ITRI.Models.Entities
{
    public partial class Plan
    {
        public int Id { get; set; }
        public byte? OrderId { get; set; }
        public byte? MemberId { get; set; }
        public byte? Time { get; set; }
        public DateTimeOffset? CreateDate { get; set; }
        public DateTimeOffset? ModifyDate { get; set; }
    }
}
