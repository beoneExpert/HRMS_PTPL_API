using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HRMSPTPLWebAPI.Models;

namespace HRMSPTPLWebAPI.Controllers
{
    public class EmployeeTypeController : ApiController
    {
        HRMS_PTPL_Entties db = new HRMS_PTPL_Entties();

        //Add Post Request
        public string Post(EmployeeType employeeType)
        {
            try
            {
                db.EmployeeTypes.Add(employeeType);
                db.SaveChanges();
                return "Data Added in EmployeeType Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        //Get All Records
        public IEnumerable<EmployeeType> Get()
        {
            return db.EmployeeTypes.ToList();
        }

        //Get Single Record
        public EmployeeType Get(int id)
        {
            try
            {
                EmployeeType employeeType = db.EmployeeTypes.Find(id);
                return employeeType;
            }
            catch (Exception)
            {
                EmployeeType employeeType = null;
                return employeeType;
            }         
        }

        //Update the Record
        public string Put(int id, EmployeeType employeeType)
        {
            try
            {
                var employeeType_ = db.EmployeeTypes.Find(id);
                employeeType_.comp_id = employeeType.comp_id;
                employeeType_.name = employeeType.name;
                employeeType_.isActive = employeeType.isActive;
                employeeType_.create_dtm = employeeType.create_dtm;
                employeeType_.update_dtm = employeeType.update_dtm;
                employeeType_.created_by = employeeType.created_by;
                employeeType_.updated_by = employeeType.updated_by;
                db.Entry(employeeType_).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Record Updated in EmployeeType Table";
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
                EmployeeType employeeType = db.EmployeeTypes.Find(id);
                db.EmployeeTypes.Remove(employeeType);
                db.SaveChanges();
                return "Record Deleted from EmployeeType Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }         
        }
    }
}
