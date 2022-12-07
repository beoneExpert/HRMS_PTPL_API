using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HRMSPTPLWebAPI.Models;

namespace HRMSPTPLWebAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        HRMS_PTPL_Entties db = new HRMS_PTPL_Entties();

        //Add Post Request
        public string Post(Employee employee)
        {
            try
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return "Data Added in Employee Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }           
        }

        //Get All Records
        public IEnumerable<Employee> Get()
        {
            return db.Employees.ToList();
        }

        //Get Single Record
        public Employee Get(int id)
        {
            try
            {
                Employee employee = db.Employees.Find(id);
                return employee;
            }
            catch (Exception)
            {
                Employee employee = null;
                return employee;
            }           
        }

        //Update the Record
        public string Put(int id, Employee employee)
        {
            try
            {
                var employee_ = db.Employees.Find(id);
                employee_.comp_id = employee.comp_id;
                employee_.loc_id = employee.loc_id;
                employee_.fname = employee.fname;
                employee_.mname = employee.mname;
                employee_.lname = employee.lname;
                employee_.deviceCode = employee.deviceCode;
                employee_.deviceEmpCode = employee.deviceEmpCode;
                employee_.emptype_id = employee.emptype_id;
                employee_.vend_id = employee.vend_id;
                employee_.user_id = employee.user_id;
                employee_.dept_id = employee.dept_id;
                employee_.team_id = employee.team_id;
                employee_.desig_id = employee.desig_id;
                employee_.leaveGroup_id = employee.leaveGroup_id;
                employee_.grade_id = employee.grade_id;
                employee_.shift_id = employee.shift_id;
                employee_.attcat_id = employee.attcat_id;
                employee_.isActive = employee.isActive;
                employee_.create_dtm = employee.create_dtm;
                employee_.update_dtm = employee.update_dtm;
                employee_.created_by = employee.created_by;
                employee_.updated_by = employee.updated_by;
                db.Entry(employee_).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Record Updated in Employee Table";
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
                Employee employee = db.Employees.Find(id);
                db.Employees.Remove(employee);
                db.SaveChanges();
                return "Record Deleted from Employee Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }            
        }
    }
}
