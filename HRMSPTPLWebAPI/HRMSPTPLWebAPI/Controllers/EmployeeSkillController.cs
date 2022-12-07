using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HRMSPTPLWebAPI.Models;

namespace HRMSPTPLWebAPI.Controllers
{
    public class EmployeeSkillController : ApiController
    {
        HRMS_PTPL_Entties db = new HRMS_PTPL_Entties();

        //Add Post Request
        public string Post(EmployeeSkill employeeSkill)
        {
            try
            {
                db.EmployeeSkills.Add(employeeSkill);
                db.SaveChanges();
                return "Data Added in EmployeeSkill Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        //Get All Records
        public IEnumerable<EmployeeSkill> Get()
        {
            return db.EmployeeSkills.ToList();
        }

        //Get Single Record
        public EmployeeSkill Get(int id)
        {
            try
            {
                EmployeeSkill employeeSkill = db.EmployeeSkills.Find(id);
                return employeeSkill;
            }
            catch (Exception)
            {
                EmployeeSkill employeeSkill = null;
                return employeeSkill;
            }           
        }

        //Update the Record
        public string Put(int id, EmployeeSkill employeeSkill)
        {
            try
            {
                var employeeSkill_ = db.EmployeeSkills.Find(id);
                employeeSkill_.comp_id = employeeSkill.comp_id;
                employeeSkill_.emp_id = employeeSkill.emp_id;
                employeeSkill_.skillName = employeeSkill.skillName;
                employeeSkill_.yearExp = employeeSkill.yearExp;
                employeeSkill_.isActive = employeeSkill.isActive;
                employeeSkill_.create_dtm = employeeSkill.create_dtm;
                employeeSkill_.update_dtm = employeeSkill.update_dtm;
                employeeSkill_.created_by = employeeSkill.created_by;
                employeeSkill_.updated_by = employeeSkill.updated_by;
                db.Entry(employeeSkill_).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Record Updated in EmployeeSkill Table";
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
                EmployeeSkill employeeSkill = db.EmployeeSkills.Find(id);
                db.EmployeeSkills.Remove(employeeSkill);
                db.SaveChanges();
                return "Record Deleted from EmployeeSkill Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }          
        }
    }
}
