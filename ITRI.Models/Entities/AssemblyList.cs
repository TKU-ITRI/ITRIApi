using System;
using System.Collections.Generic;

namespace ITRI.Models.Entities
{
    public partial class AssemblyList
    {
        public int Id { get; set; }
        public int? AListImage { get; set; }
        public int? AListMemberName { get; set; }
        public int? AListTool { get; set; }
        public DateTimeOffset? AListPredictDate { get; set; }
        public DateTimeOffset? AListCompleteDate { get; set; }
        public int? AGonNo { get; set; }
        public DateTimeOffset? CreateDate { get; set; }
        public DateTimeOffset? ModifyDate { get; set; }

        public virtual Gon AGonNoNavigation { get; set; }
    }
}
