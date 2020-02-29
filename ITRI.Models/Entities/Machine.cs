using System;
using System.Collections.Generic;

namespace ITRI.Models.Entities
{
    public partial class Machine
    {
        public int Id { get; set; }
        public string MachineClass { get; set; }
        public string MachineName { get; set; }
        public string MachineNo { get; set; }
        public string MachineBrand { get; set; }
        public string MachineSize { get; set; }
        public byte? MachineStatus { get; set; }
        public DateTimeOffset? MachineUsingTime { get; set; }
        public DateTimeOffset? MachineEndingTime { get; set; }
        public DateTimeOffset? MachineTableCreateDate { get; set; }
        public DateTimeOffset? MachineTableModifyDate { get; set; }
        public int? AccountId { get; set; }
        public int? CompanyId { get; set; }
    }
}
