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
    
    public partial class EmployeeJobHistory
    {
        public Nullable<int> comp_id { get; set; }
        public Nullable<int> emp_id { get; set; }
        public int jhis_id { get; set; }
        public string orgName { get; set; }
        public string orgAddress { get; set; }
        public string orgContactNo { get; set; }
        public Nullable<System.DateTime> fromDate { get; set; }
        public Nullable<System.DateTime> toDate { get; set; }
        public string disgnation { get; set; }
        public string regReason { get; set; }
        public Nullable<bool> isActive { get; set; }
        public Nullable<System.DateTime> create_dtm { get; set; }
        public Nullable<System.DateTime> update_dtm { get; set; }
        public Nullable<int> created_by { get; set; }
        public Nullable<int> updated_by { get; set; }
    }
}
