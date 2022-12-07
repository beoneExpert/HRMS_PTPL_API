using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using HRMSPTPLWebAPI.Models;

namespace HRMSPTPLWebAPI.Controllers
{
    public class HolidayController : ApiController
    {
        HRMS_PTPL_Entties db = new HRMS_PTPL_Entties();

        //Add Post Request
        public string Post(Holiday holiday)
        {
            try
            {
                db.Holidays.Add(holiday);
                db.SaveChanges();
                return "Data Added in Holiday Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }           
        }

        //Get All Records
        public IEnumerable<Holiday> Get()
        {
            return db.Holidays.ToList();
        }

        private const string ErrorViewName = "Error";
        //Get Single Record
        public Holiday Get(int id)
        {
            try
            {
                Holiday holiday = db.Holidays.Find(id);
                return holiday;
            }
            catch (Exception)
            {
                Holiday holiday = null;
                return holiday;
            }           
        }

        //Update the Record
        public string Put(int id, Holiday holiday)
        {
            try
            {
                var holiday_ = db.Holidays.Find(id);
                holiday_.comp_id = holiday.comp_id;
                holiday_.holidayDate = holiday.holidayDate;
                holiday_.name = holiday.name;
                holiday_.isActive = holiday.isActive;
                holiday_.create_dtm = holiday.create_dtm;
                holiday_.update_dtm = holiday.update_dtm;
                holiday_.created_by = holiday.created_by;
                holiday_.updated_by = holiday.updated_by;
                db.Entry(holiday_).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Record Updated in Holiday Table";
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
                Holiday holiday = db.Holidays.Find(id);
                db.Holidays.Remove(holiday);
                db.SaveChanges();
                return "Record Deleted from Holiday Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }          
        }
    }
}
