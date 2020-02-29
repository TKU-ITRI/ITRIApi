using System;
using System.Collections.Generic;

namespace ITRI.Models.Entities
{
    public partial class Member
    {
        public int Id { get; set; }
        public string MemberNo { get; set; }
        public string MemberName { get; set; }
        public string MemberDuties { get; set; }
        public string MemberSubDuties { get; set; }
        public DateTimeOffset? MemberHiringDay { get; set; }
        public DateTimeOffset? MemberFiringDay { get; set; }
        public int? MemberTransferMemberId { get; set; }
        public DateTimeOffset? CreateDate { get; set; }
        public DateTimeOffset? ModifyDate { get; set; }
        public int? AccountId { get; set; }
        public int? CompanyId { get; set; }
    }
}
