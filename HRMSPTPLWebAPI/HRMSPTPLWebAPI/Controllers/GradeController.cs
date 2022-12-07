using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HRMSPTPLWebAPI.Models;

namespace HRMSPTPLWebAPI.Controllers
{
    public class GradeController : ApiController
    {
        HRMS_PTPL_Entties db = new HRMS_PTPL_Entties();

        //Add Post Request
        public string Post(Grade grade)
        {
            try
            {
                db.Grades.Add(grade);
                db.SaveChanges();
                return "Data Added in Grade Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }         
        }

        //Get All Records
        public IEnumerable<Grade> Get()
        {
            return db.Grades.ToList();
        }

        //Get Single Record
        public Grade Get(int id)
        {
            try
            {
                Grade grade = db.Grades.Find(id);
                return grade;
            }
            catch (Exception)
            {
                Grade grade = null;
                return grade;
            }        
        }

        //Update the Record
        public string Put(int id, Grade grade)
        {
            try
            {
                var grade_ = db.Grades.Find(id);
                grade_.comp_id = grade.comp_id;
                grade_.name = grade.name;
                grade_.isActive = grade.isActive;
                grade_.create_dtm = grade.create_dtm;
                grade_.update_dtm = grade.update_dtm;
                grade_.created_by = grade.created_by;
                grade_.updated_by = grade.updated_by;
                db.Entry(grade_).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Record Updated in Grade Table";
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
                Grade grade = db.Grades.Find(id);
                db.Grades.Remove(grade);
                db.SaveChanges();
                return "Record Deleted from Grade Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }          
        }
    }
}
