using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HRMSPTPLWebAPI.Models;

namespace HRMSPTPLWebAPI.Controllers
{
    public class EmployeePayHeaderController : ApiController
    {
        HRMS_PTPL_Entties db = new HRMS_PTPL_Entties();

        //Add Post Request
        public string Post(EmployeePayHeader employeePayHeader)
        {
            try
            {
                db.EmployeePayHeaders.Add(employeePayHeader);
                db.SaveChanges();
                return "Data Added in EmployeePayHeader Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }         
        }

        //Get All Records
        public IEnumerable<EmployeePayHeader> Get()
        {
            return db.EmployeePayHeaders.ToList();
        }

        //Get Single Record
        public EmployeePayHeader Get(int id)
        {
            try
            {
                EmployeePayHeader employeePayHeader = db.EmployeePayHeaders.Find(id);
                return employeePayHeader;
            }
            catch (Exception)
            {
                EmployeePayHeader employeePayHeader = null;
                return employeePayHeader;
            }           
        }

        //Update the Record
        public string Put(int id, EmployeePayHeader employeePayHeader)
        {
            try
            {
                var employeePayHeader_ = db.EmployeePayHeaders.Find(id);
                employeePayHeader_.comp_id = employeePayHeader.comp_id;
                employeePayHeader_.emp_id = employeePayHeader.emp_id;
                employeePayHeader_.payType = employeePayHeader.payType;
                employeePayHeader_.bankName = employeePayHeader.bankName;
                employeePayHeader_.bankAcctNo = employeePayHeader.bankAcctNo;
                employeePayHeader_.bankIFSE = employeePayHeader.bankIFSE;
                employeePayHeader_.effectiveFrom = employeePayHeader.effectiveFrom;
                employeePayHeader_.effectiveTo = employeePayHeader.effectiveTo;
                employeePayHeader_.isActive = employeePayHeader.isActive;
                employeePayHeader_.create_dtm = employeePayHeader.create_dtm;
                employeePayHeader_.update_dtm = employeePayHeader.update_dtm;
                employeePayHeader_.created_by = employeePayHeader.created_by;
                employeePayHeader_.updated_by = employeePayHeader.updated_by;
                db.Entry(employeePayHeader_).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Record Updated in EmployeePayHeader Table";
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
                EmployeePayHeader employeePayHeader = db.EmployeePayHeaders.Find(id);
                db.EmployeePayHeaders.Remove(employeePayHeader);
                db.SaveChanges();
                return "Record Deleted from EmployeePayHeader Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }          
        }
    }
}
