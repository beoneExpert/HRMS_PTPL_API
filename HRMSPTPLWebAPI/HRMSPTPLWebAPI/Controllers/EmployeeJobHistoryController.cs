using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HRMSPTPLWebAPI.Models;

namespace HRMSPTPLWebAPI.Controllers
{
    public class EmployeeJobHistoryController : ApiController
    {
        HRMS_PTPL_Entties db = new HRMS_PTPL_Entties();

        //Add Post Request
        public string Post(EmployeeJobHistory employeejobhistory)
        {
            try
            {
                db.EmployeeJobHistories.Add(employeejobhistory);
                db.SaveChanges();
                return "Data Added in EmployeeJobHistory Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }           
        }

        //Get All Records
        public IEnumerable<EmployeeJobHistory> Get()
        {
            return db.EmployeeJobHistories.ToList();
        }

        //Get Single Record
        public EmployeeJobHistory Get(int id)
        {
            try
            {
                EmployeeJobHistory employeejobhistory = db.EmployeeJobHistories.Find(id);
                return employeejobhistory;
            }
            catch (Exception)
            {
                EmployeeJobHistory employeejobhistory = null;
                return employeejobhistory;
            }
        }

        //Update the Record
        public string Put(int id, EmployeeJobHistory employeejobhistory)
        {
            try
            {
                var employeejobhistory_ = db.EmployeeJobHistories.Find(id);
                employeejobhistory_.comp_id = employeejobhistory.comp_id;
                employeejobhistory_.emp_id = employeejobhistory.emp_id;
                employeejobhistory_.orgName = employeejobhistory.orgName;
                employeejobhistory_.orgAddress = employeejobhistory.orgAddress;
                employeejobhistory_.orgContactNo = employeejobhistory.orgContactNo;
                employeejobhistory_.fromDate = employeejobhistory.fromDate;
                employeejobhistory_.toDate = employeejobhistory.toDate;
                employeejobhistory_.disgnation = employeejobhistory.disgnation;
                employeejobhistory_.regReason = employeejobhistory.regReason;
                employeejobhistory_.isActive = employeejobhistory.isActive;
                employeejobhistory_.create_dtm = employeejobhistory.create_dtm;
                employeejobhistory_.update_dtm = employeejobhistory.update_dtm;
                employeejobhistory_.created_by = employeejobhistory.created_by;
                employeejobhistory_.updated_by = employeejobhistory.updated_by;
                db.Entry(employeejobhistory_).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Record Updated in EmployeeJobHistory Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }           
        }

        //Delete the Record
        public string Delete(int id)
        {
            try
            {
                EmployeeJobHistory employeejobhistory = db.EmployeeJobHistories.Find(id);
                db.EmployeeJobHistories.Remove(employeejobhistory);
                db.SaveChanges();
                return "Record Deleted from EmployeeJobHistory Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }           
        }
    }
}
