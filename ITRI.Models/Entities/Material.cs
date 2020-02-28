using System;
using System.Collections.Generic;

namespace ITRI.Models.Entities
{
    public partial class Material
    {
        public int Id { get; set; }
        public byte? OrderId { get; set; }
        public byte? MemberId { get; set; }
        public string MaterialClass { get; set; }
        public string MaterialName { get; set; }
        public int? MaterialNo { get; set; }
        public string MaterialBrand { get; set; }
        public string MaterialSize { get; set; }
        public int? MaterialCount { get; set; }
        public byte? MaterialStatus { get; set; }
        public DateTimeOffset? MaterialTableCreateDate { get; set; }
        public DateTimeOffset? MaterialTableModifyDate { get; set; }
    }
}
