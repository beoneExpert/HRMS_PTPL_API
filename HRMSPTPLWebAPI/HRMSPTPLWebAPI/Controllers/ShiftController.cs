using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HRMSPTPLWebAPI.Models;

namespace HRMSPTPLWebAPI.Controllers
{
    public class ShiftController : ApiController
    {
        HRMS_PTPL_Entties db = new HRMS_PTPL_Entties();

        //Add Post Request
        public string Post(Shift shift)
        {
            try
            {
                db.Shifts.Add(shift);
                db.SaveChanges();
                return "Data Added in Shift Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        //Get All Records
        public IEnumerable<Shift> Get()
        {
            return db.Shifts.ToList();
        }

        //Get Single Record
        public Shift Get(int id)
        {
            try
            {
                Shift shift = db.Shifts.Find(id);
                return shift;
            }
            catch (Exception)
            {
                Shift shift = null;
                return shift;
            }
        }

        //Update the Record
        public string Put(int id, Shift shift)
        {
            try
            {
                var shift_ = db.Shifts.Find(id);
                shift_.comp_id = shift.comp_id;
                shift_.name = shift.name;
                shift_.shortName = shift.shortName;
                shift_.beginTime24 = shift.beginTime24;
                shift_.endTime24 = shift.endTime24;
                shift_.berak1 = shift.berak1;
                shift_.b1beginTime24 = shift.b1beginTime24;
                shift_.b1endTime24 = shift.b1endTime24;
                shift_.berak2 = shift.berak2;
                shift_.b2beginTime24 = shift.b2beginTime24;
                shift_.b2endTime24 = shift.b2endTime24;
                shift_.isFlexShift = shift.isFlexShift;
                shift_.punchBeginBeforeMin = shift.punchBeginBeforeMin;
                shift_.punchEndAfterMin = shift.punchEndAfterMin;
                shift_.graceTimeMin = shift.graceTimeMin;
                shift_.partialDaysOn = shift.partialDaysOn;
                shift_.partialDay = shift.partialDay;
                shift_.partialDayBegin = shift.partialDayBegin;
                shift_.partialDayEnd = shift.partialDayEnd;
                shift_.isActive = shift.isActive;
                shift_.create_dtm = shift.create_dtm;
                shift_.update_dtm = shift.update_dtm;
                shift_.created_by = shift.created_by;
                shift_.updated_by = shift.updated_by;
                db.Entry(shift_).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Record Updated in Shift Table";
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
                Shift shift = db.Shifts.Find(id);
                db.Shifts.Remove(shift);
                db.SaveChanges();
                return "Record Deleted from Shift Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
