using System;
using System.Collections.Generic;

namespace ITRI.Models.Entities
{
    public partial class Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public byte? Active { get; set; }
        public DateTimeOffset? CreateDate { get; set; }
        public DateTimeOffset? ModifyDate { get; set; }
    }
}
