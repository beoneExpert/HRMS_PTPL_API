using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HRMSPTPLWebAPI.Models;

namespace HRMSPTPLWebAPI.Controllers
{
    public class LeaveGroupDetailController : ApiController
    {
        HRMS_PTPL_Entties db = new HRMS_PTPL_Entties();

        //Add Post Request
        public string Post(LeaveGroupDetail leaveGroupDetail)
        {
            try
            {
                db.LeaveGroupDetails.Add(leaveGroupDetail);
                db.SaveChanges();
                return "Data Added in LeaveGroupDetails Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        //Get All Records
        public IEnumerable<LeaveGroupDetail> Get()
        {
            return db.LeaveGroupDetails.ToList();
        }

        //Get Single Record
        public LeaveGroupDetail Get(int id)
        {
            try
            {
                LeaveGroupDetail leaveGroupDetail = db.LeaveGroupDetails.Find(id);
                return leaveGroupDetail;
            }
            catch (Exception)
            {
                LeaveGroupDetail leaveGroupDetail = null;
                return leaveGroupDetail;
            }
        }

        //Update the Record
        public string Put(int id, LeaveGroupDetail leaveGroupDetail)
        {
            try
            {
                var leaveGroupDetail_ = db.LeaveGroupDetails.Find(id);
                leaveGroupDetail_.comp_id = leaveGroupDetail.comp_id;
                leaveGroupDetail_.leaveGroup_id = leaveGroupDetail.leaveGroup_id;
                leaveGroupDetail_.leave_id = leaveGroupDetail.leave_id;
                leaveGroupDetail_.noDays = leaveGroupDetail.noDays;
                leaveGroupDetail_.monthlyExp = leaveGroupDetail.monthlyExp;
                leaveGroupDetail_.monthlyDays = leaveGroupDetail.monthlyDays;
                leaveGroupDetail_.yearlyExp = leaveGroupDetail.yearlyExp;
                leaveGroupDetail_.yearlyDays = leaveGroupDetail.yearlyDays;
                leaveGroupDetail_.isAppNP = leaveGroupDetail.isAppNP;
                leaveGroupDetail_.isAppProb = leaveGroupDetail.isAppProb;
                db.Entry(leaveGroupDetail_).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Record Updated in LeaveGroupDetails Table";
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
                LeaveGroupDetail leaveGroupDetail = db.LeaveGroupDetails.Find(id);
                db.LeaveGroupDetails.Remove(leaveGroupDetail);
                db.SaveChanges();
                return "Record Deleted from LeaveGroupDetails Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
