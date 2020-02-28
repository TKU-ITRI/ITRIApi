using System;
using System.Collections.Generic;

namespace ITRI.Models.Entities
{
    public partial class Account
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int? CompanyId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string NickName { get; set; }
        public string Token { get; set; }
        public byte? Active { get; set; }
        public DateTimeOffset? CreateDate { get; set; }
        public DateTimeOffset? ModifyDate { get; set; }
        public string Test { get; set; }
    }
}
