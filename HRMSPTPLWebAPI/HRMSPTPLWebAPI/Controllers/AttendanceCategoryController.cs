using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using HRMSPTPLWebAPI.Models;

namespace HRMSPTPLWebAPI.Controllers
{
    public class AttendanceCategoryController : ApiController
    {
        HRMS_PTPL_Entties db = new HRMS_PTPL_Entties();

        //Add Post Request
        public string Post(AttendanceCategory attendancecategory)
        {
            try
            {
                db.AttendanceCategories.Add(attendancecategory);
                db.SaveChanges();
                return "Data Added in AttendanceCategory Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        //Get All Records
        public IEnumerable<AttendanceCategory> Get()
        {
            return db.AttendanceCategories.ToList();
        }

        //Get Single Record
        public AttendanceCategory Get(int id)
        {
            try
            {
                AttendanceCategory attendancecategory = db.AttendanceCategories.Find(id);
                return attendancecategory;
            }
            catch (Exception)
            {
                AttendanceCategory attendancecategory = null;
                return attendancecategory;
            }
        }

        //Update the Record
        public string Put(int id, AttendanceCategory attendancecategory)
        {
            try
            {
                var attendancecategory_ = db.AttendanceCategories.Find(id);
                attendancecategory_.comp_id = attendancecategory.comp_id;
                attendancecategory_.name = attendancecategory.name;
                attendancecategory_.shortName = attendancecategory.shortName;
                attendancecategory_.otFormula_id = attendancecategory.otFormula_id;
                attendancecategory_.minOTmin = attendancecategory.minOTmin;
                attendancecategory_.maxOTmin = attendancecategory.maxOTmin;
                attendancecategory_.graceLateMin = attendancecategory.graceLateMin;
                attendancecategory_.graceEarlyMin = attendancecategory.graceEarlyMin;
                attendancecategory_.isWeekOffDay1 = attendancecategory.isWeekOffDay1;
                attendancecategory_.weekOffDay1 = attendancecategory.weekOffDay1;
                attendancecategory_.isWeekOffDay2 = attendancecategory.isWeekOffDay2;
                attendancecategory_.weekOffDay2 = attendancecategory.weekOffDay2;
                attendancecategory_.weekOffDay2_1 = attendancecategory.weekOffDay2_1;
                attendancecategory_.weekOffDay2_2 = attendancecategory.weekOffDay2_2;
                attendancecategory_.weekOffDay2_3 = attendancecategory.weekOffDay2_3;
                attendancecategory_.weekOffDay2_4 = attendancecategory.weekOffDay2_4;
                attendancecategory_.weekOffDay2_5 = attendancecategory.weekOffDay2_5;
                attendancecategory_.consEarlyPunch = attendancecategory.consEarlyPunch;
                attendancecategory_.consLateGoPunch = attendancecategory.consLateGoPunch;
                attendancecategory_.deductBreak = attendancecategory.deductBreak;
                attendancecategory_.cal_HD_WD_LT_Min = attendancecategory.cal_HD_WD_LT_Min;
                attendancecategory_.cal_AB_WD_LT_Min = attendancecategory.cal_AB_WD_LT_Min;
                attendancecategory_.cal_PD_HD_WD_LT_Min = attendancecategory.cal_PD_HD_WD_LT_Min;
                attendancecategory_.cal_PD_AB_WD_LT_Min = attendancecategory.cal_PD_AB_WD_LT_Min;
                attendancecategory_.isAbs_Prefix_Day_Abs = attendancecategory.isAbs_Prefix_Day_Abs;
                attendancecategory_.isAbs_Suffix_Day_Abs = attendancecategory.isAbs_Suffix_Day_Abs;
                attendancecategory_.isAbs_Prefix_Suffix_Day_Abs = attendancecategory.isAbs_Prefix_Suffix_Day_Abs;
                attendancecategory_.isHalfDayLateDays = attendancecategory.isHalfDayLateDays;
                attendancecategory_.calHalfDayLateDays = attendancecategory.calHalfDayLateDays;
                attendancecategory_.isAbsentLateDays = attendancecategory.isAbsentLateDays;
                attendancecategory_.calAbsentLateDays = attendancecategory.calAbsentLateDays;
                attendancecategory_.isHalfDayByLate = attendancecategory.isHalfDayByLate;
                attendancecategory_.calHalfDayByMin = attendancecategory.calHalfDayByMin;
                attendancecategory_.isHalfDayByEarly = attendancecategory.isHalfDayByEarly;
                attendancecategory_.calHalfDayByEarlyMin = attendancecategory.calHalfDayByEarlyMin;
                attendancecategory_.isActive = attendancecategory.isActive;
                attendancecategory_.create_dtm = attendancecategory.create_dtm;
                attendancecategory_.update_dtm = attendancecategory.update_dtm;
                attendancecategory_.created_by = attendancecategory.created_by;
                attendancecategory_.updated_by = attendancecategory.updated_by;
                db.Entry(attendancecategory_).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Record Updated in AttendanceCategory Table";
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
                AttendanceCategory attendancecategory = db.AttendanceCategories.Find(id);
                db.AttendanceCategories.Remove(attendancecategory);
                db.SaveChanges();
                return "Record Deleted from AttendanceCategory Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
