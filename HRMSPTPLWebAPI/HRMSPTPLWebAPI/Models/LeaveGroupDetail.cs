//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRMSPTPLWebAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LeaveGroupDetail
    {
        public Nullable<int> comp_id { get; set; }
        public Nullable<int> leaveGroup_id { get; set; }
        public int line_id { get; set; }
        public Nullable<int> leave_id { get; set; }
        public Nullable<int> noDays { get; set; }
        public Nullable<bool> monthlyExp { get; set; }
        public Nullable<int> monthlyDays { get; set; }
        public Nullable<bool> yearlyExp { get; set; }
        public Nullable<int> yearlyDays { get; set; }
        public Nullable<bool> isAppNP { get; set; }
        public Nullable<bool> isAppProb { get; set; }
    }
}
