using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HRMSPTPLWebAPI.Models;

namespace HRMSPTPLWebAPI.Controllers
{
    public class EmployeeVendorController : ApiController
    {
        HRMS_PTPL_Entties db = new HRMS_PTPL_Entties();

        //Add Post Request
        public string Post(EmployeeVendor employeeVendor)
        {
            try
            {
                db.EmployeeVendors.Add(employeeVendor);
                db.SaveChanges();
                return "Data Added in EmployeeVendor Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }           
        }

        //Get All Records
        public IEnumerable<EmployeeVendor> Get()
        {
            return db.EmployeeVendors.ToList();
        }

        //Get Single Record
        public EmployeeVendor Get(int id)
        {
            try
            {
                EmployeeVendor employeeVendor = db.EmployeeVendors.Find(id);
                return employeeVendor;
            }
            catch (Exception)
            {
                EmployeeVendor employeeVendor = null;
                return employeeVendor;
            }
        }

        //Update the Record
        public string Put(int id, EmployeeVendor employeeVendor)
        {
            try
            {
                var employeeVendor_ = db.EmployeeVendors.Find(id);
                employeeVendor_.fname = employeeVendor.fname;
                employeeVendor_.mname = employeeVendor.mname;
                employeeVendor_.lname = employeeVendor.lname;
                employeeVendor_.user_id = employeeVendor.user_id;
                employeeVendor_.comp_id = employeeVendor.comp_id;
                employeeVendor_.isActive = employeeVendor.isActive;
                employeeVendor_.create_dtm = employeeVendor.create_dtm;
                employeeVendor_.update_dtm = employeeVendor.update_dtm;
                employeeVendor_.created_by = employeeVendor.created_by;
                employeeVendor_.updated_by = employeeVendor.updated_by;
                db.Entry(employeeVendor_).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Record Updated in EmployeeVendor Table";
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
                EmployeeVendor employeeVendor = db.EmployeeVendors.Find(id);
                db.EmployeeVendors.Remove(employeeVendor);
                db.SaveChanges();
                return "Record Deleted from EmployeeVendor Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }           
        }
    }
}
