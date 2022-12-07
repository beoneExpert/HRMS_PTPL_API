using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HRMSPTPLWebAPI.Models;

namespace HRMSPTPLWebAPI.Controllers
{
    public class EmployeeNomineeController : ApiController
    {
        HRMS_PTPL_Entties db = new HRMS_PTPL_Entties();

        //Add Post Request
        public string Post(EmployeeNominee employeeNominee)
        {
            try
            {
                db.EmployeeNominees.Add(employeeNominee);
                db.SaveChanges();
                return "Data Added in EmployeeNominee Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        //Get All Records
        public IEnumerable<EmployeeNominee> Get()
        {
            return db.EmployeeNominees.ToList();
        }

        //Get Single Record
        public EmployeeNominee Get(int id)
        {
            try
            {
                EmployeeNominee employeeNominee = db.EmployeeNominees.Find(id);
                return employeeNominee;
            }
            catch (Exception)
            {
                EmployeeNominee employeeNominee = null;
                return employeeNominee;
            }          
        }

        //Update the Record
        public string Put(int id, EmployeeNominee employeeNominee)
        {
            try
            {
                var employeeNominee_ = db.EmployeeNominees.Find(id);
                employeeNominee_.comp_id = employeeNominee.comp_id;
                employeeNominee_.emp_id = employeeNominee.emp_id;
                employeeNominee_.nomineeName = employeeNominee.nomineeName;
                employeeNominee_.perAddress = employeeNominee.perAddress;
                employeeNominee_.mobNo = employeeNominee.mobNo;
                employeeNominee_.mobNo1 = employeeNominee.mobNo1;
                employeeNominee_.whatsupNo = employeeNominee.whatsupNo;
                employeeNominee_.primEmail = employeeNominee.primEmail;
                employeeNominee_.alterEmail = employeeNominee.alterEmail;
                employeeNominee_.relation = employeeNominee.relation;
                employeeNominee_.isActive = employeeNominee.isActive;
                employeeNominee_.create_dtm = employeeNominee.create_dtm;
                employeeNominee_.update_dtm = employeeNominee.update_dtm;
                employeeNominee_.created_by = employeeNominee.created_by;
                employeeNominee_.updated_by = employeeNominee.updated_by;
                db.Entry(employeeNominee_).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Record Updated in EmployeeNominee Table";
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
                EmployeeNominee employeeNominee = db.EmployeeNominees.Find(id);
                db.EmployeeNominees.Remove(employeeNominee);
                db.SaveChanges();
                return "Record Deleted from EmployeeNominee Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }          
        }
    }
}
