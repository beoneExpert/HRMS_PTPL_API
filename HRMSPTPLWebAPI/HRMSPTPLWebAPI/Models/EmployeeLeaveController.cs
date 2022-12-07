using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HRMSPTPLWebAPI.Models
{
    public class EmployeeLeaveController : ApiController
    {
        SecondEntities db = new SecondEntities();

        //Add Post Request  //Insert Into Table (POST)
        public string Post(EmployeeLeave employeeleave)
        {
            try
            {
                db.EmployeeLeaves.Add(employeeleave);
                db.SaveChanges();
                return "Data Added in EmployeeLeave Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        //Get All Records // Select * from Table
        public IEnumerable<EmployeeLeave> Get()
        {
            return db.EmployeeLeaves.ToList();
        }

        //Get Single Record // Select * from table where id = ..    (GET)
        public EmployeeLeave Get(int id)
        {
            try
            {
                EmployeeLeave employeeleave = db.EmployeeLeaves.Find(id);
                return employeeleave;
            }
            catch (Exception)
            {
                EmployeeLeave employeeleave = null;
                return employeeleave;
            }
        }

        //Update the Record //update table where id =.. or update table where company = ..  (PUT)
        public string Put(int id, EmployeeLeave employeeleave)
        {
            try
            {
                var employeeleave_ = db.EmployeeLeaves.Find(id);
                employeeleave_.comp_id = employeeleave.comp_id;
                employeeleave_.emp_id = employeeleave.emp_id;
                employeeleave_.leave_id = employeeleave.leave_id;
                employeeleave_.fromDate = employeeleave.fromDate;
                employeeleave_.toDate = employeeleave.toDate;
                employeeleave_.leaveReason = employeeleave.leaveReason;
                employeeleave_.leaveStatus = employeeleave.leaveStatus;
                employeeleave_.rejReason = employeeleave.rejReason;
                employeeleave_.apprvedBy = employeeleave.apprvedBy;
                employeeleave_.isActive = employeeleave.isActive;
                employeeleave_.create_dtm = employeeleave.create_dtm;
                employeeleave_.update_dtm = employeeleave.update_dtm;
                employeeleave_.created_by = employeeleave.created_by;
                employeeleave_.updated_by = employeeleave.updated_by;

                db.Entry(employeeleave_).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Record Updated in EmployeeLeave Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        //Delete the Record //delete from table where id = .. (DELETE)
        public string Delete(int id)
        {
            try
            {
                EmployeeLeave employeeleave = db.EmployeeLeaves.Find(id);
                db.EmployeeLeaves.Remove(employeeleave);
                db.SaveChanges();
                return "Record Deleted from EmployeeLeave Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
