using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HRMSPTPLWebAPI.Models;

namespace HRMSPTPLWebAPI.Controllers
{
    public class EmployeeEducationController : ApiController
    {
        HRMS_PTPL_Entties db = new HRMS_PTPL_Entties();

        //Add Post Request
        public string Post(EmployeeEducation employeeEducation)
        {
            try
            {
                db.EmployeeEducations.Add(employeeEducation);
                db.SaveChanges();
                return "Data Added in EmployeeEducations Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        //Get All Records
        public IEnumerable<EmployeeEducation> Get()
        {
            return db.EmployeeEducations.ToList();
        }

        //Get Single Record
        public EmployeeEducation Get(int id)
        {
            try
            {
                EmployeeEducation employeeEducation = db.EmployeeEducations.Find(id);
                return employeeEducation;
            }
            catch (Exception)
            {
                EmployeeEducation employeeEducation = null;
                return employeeEducation;
            }
        }

        //Update the Record
        public string Put(int id, EmployeeEducation employeeEducation)
        {
            try
            {
                var employeeEducation_ = db.EmployeeEducations.Find(id);
                employeeEducation_.comp_id = employeeEducation.comp_id;
                employeeEducation_.emp_id = employeeEducation.emp_id;
                employeeEducation_.courseName = employeeEducation.courseName;
                employeeEducation_.university = employeeEducation.university;
                employeeEducation_.fromDate = employeeEducation.fromDate;
                employeeEducation_.toDate = employeeEducation.toDate;
                employeeEducation_.passoutYear = employeeEducation.passoutYear;
                employeeEducation_.grade = employeeEducation.grade;
                employeeEducation_.isActive = employeeEducation.isActive;
                employeeEducation_.create_dtm = employeeEducation.create_dtm;
                employeeEducation_.update_dtm = employeeEducation.update_dtm;
                employeeEducation_.created_by = employeeEducation.created_by;
                employeeEducation_.updated_by = employeeEducation.updated_by;
                db.Entry(employeeEducation_).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Record Updated in EmployeeEducation Table";
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
                EmployeeEducation employeeEducation = db.EmployeeEducations.Find(id);
                db.EmployeeEducations.Remove(employeeEducation);
                db.SaveChanges();
                return "Record Deleted from EmployeeEducation Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }           
        }
    }
}
