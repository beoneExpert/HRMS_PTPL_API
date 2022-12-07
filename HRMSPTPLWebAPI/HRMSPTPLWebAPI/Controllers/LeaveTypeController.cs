using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HRMSPTPLWebAPI.Models;

namespace HRMSPTPLWebAPI.Controllers
{
    public class LeaveTypeController : ApiController
    {
        HRMS_PTPL_Entties db = new HRMS_PTPL_Entties();

        //Add Post Request
        public string Post(LeaveType leaveType)
        {
            try
            {
                db.LeaveTypes.Add(leaveType);
                db.SaveChanges();
                return "Data Added in LeaveType Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        //Get All Records
        public IEnumerable<LeaveType> Get()
        {
            return db.LeaveTypes.ToList();
        }

        //Get Single Record
        public LeaveType Get(int id)
        {
            try
            {
                LeaveType leaveType = db.LeaveTypes.Find(id);
                return leaveType;
            }
            catch (Exception)
            {
                LeaveType leaveType = null;
                return leaveType;
            }
        }

        //Update the Record
        public string Put(int id, LeaveType leaveType)
        {
            try
            {
                var leaveType_ = db.LeaveTypes.Find(id);
                leaveType_.comp_id = leaveType.comp_id;
                leaveType_.name = leaveType.name;
                leaveType_.shortName = leaveType.shortName;
                leaveType_.gender = leaveType.gender;
                leaveType_.isActive = leaveType.isActive;
                leaveType_.create_dtm = leaveType.create_dtm;
                leaveType_.update_dtm = leaveType.update_dtm;
                leaveType_.created_by = leaveType.created_by;
                leaveType_.updated_by = leaveType.updated_by;
                db.Entry(leaveType_).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Record Updated in LeaveType Table";
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
                LeaveType leaveType = db.LeaveTypes.Find(id);
                db.LeaveTypes.Remove(leaveType);
                db.SaveChanges();
                return "Record Deleted from LeaveType Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
