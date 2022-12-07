using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HRMSPTPLWebAPI.Models;

namespace HRMSPTPLWebAPI.Controllers
{
    public class LeaveGroupController : ApiController
    {
        HRMS_PTPL_Entties db = new HRMS_PTPL_Entties();

        //Add Post Request
        public string Post(LeaveGroup leaveGroup)
        {
            try
            {
                db.LeaveGroups.Add(leaveGroup);
                db.SaveChanges();
                return "Data Added in LeaveGroup Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }          
        }

        //Get All Records
        public IEnumerable<LeaveGroup> Get()
        {
            return db.LeaveGroups.ToList();
        }

        //Get Single Record
        public LeaveGroup Get(int id)
        {
            try
            {
                LeaveGroup leaveGroup = db.LeaveGroups.Find(id);
                return leaveGroup;
            }
            catch (Exception)
            {
                LeaveGroup leaveGroup = null;
                return leaveGroup;
            }
        }

        //Update the Record
        public string Put(int id, LeaveGroup leaveGroup)
        {
            try
            {
                var leaveGroup_ = db.LeaveGroups.Find(id);
                leaveGroup_.comp_id = leaveGroup.comp_id;
                leaveGroup_.name = leaveGroup.name;
                leaveGroup_.shortName = leaveGroup.shortName;
                leaveGroup_.isActive = leaveGroup.isActive;
                leaveGroup_.create_dtm = leaveGroup.create_dtm;
                leaveGroup_.update_dtm = leaveGroup.update_dtm;
                leaveGroup_.created_by = leaveGroup.created_by;
                leaveGroup_.updated_by = leaveGroup.updated_by;
                db.Entry(leaveGroup_).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Record Updated in LeaveGroup Table";
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
                LeaveGroup leaveGroup = db.LeaveGroups.Find(id);
                db.LeaveGroups.Remove(leaveGroup);
                db.SaveChanges();
                return "Record Deleted from LeaveGroup Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
