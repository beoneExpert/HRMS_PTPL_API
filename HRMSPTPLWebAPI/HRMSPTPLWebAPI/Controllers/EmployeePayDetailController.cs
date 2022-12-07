using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HRMSPTPLWebAPI.Models;

namespace HRMSPTPLWebAPI.Controllers
{
    public class EmployeePayDetailController : ApiController
    {
        HRMS_PTPL_Entties db = new HRMS_PTPL_Entties();

        //Add Post Request
        public string Post(EmployeePayDetail employeePayDetail)
        {
            try
            {
                db.EmployeePayDetails.Add(employeePayDetail);
                db.SaveChanges();
                return "Data Added in EmployeePayDetails Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }         
        }

        //Get All Records
        public IEnumerable<EmployeePayDetail> Get()
        {
            return db.EmployeePayDetails.ToList();
        }

        //Get Single Record
        public EmployeePayDetail Get(int id)
        {
            try
            {
                EmployeePayDetail employeePayDetail = db.EmployeePayDetails.Find(id);
                return employeePayDetail;
            }
            catch (Exception)
            {
                EmployeePayDetail employeePayDetail = null;
                return employeePayDetail;
            }  
        }

        //Update the Record
        public string Put(int id, EmployeePayDetail employeePayDetail)
        {
            try
            {
                var employeePayDetail_ = db.EmployeePayDetails.Find(id);
                employeePayDetail_.comp_id = employeePayDetail.comp_id;
                employeePayDetail_.pay_id = employeePayDetail.pay_id;
                employeePayDetail_.emp_id = employeePayDetail.emp_id;
                db.Entry(employeePayDetail_).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Record Updated in EmployeePayDetails Table";
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
                EmployeePayDetail employeePayDetail = db.EmployeePayDetails.Find(id);
                db.EmployeePayDetails.Remove(employeePayDetail);
                db.SaveChanges();
                return "Record Deleted from EmployeePayDetails Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }          
        }
    }
}
