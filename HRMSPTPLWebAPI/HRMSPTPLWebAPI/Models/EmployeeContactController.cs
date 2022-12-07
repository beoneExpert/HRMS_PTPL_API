using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HRMSPTPLWebAPI.Models;

namespace HRMSPTPLWebAPI.Models
{
    public class EmployeeContactController : ApiController
    {
        SecondEntities db = new SecondEntities();

        //Add Post Request  //Insert Into Table (POST)
        public string Post(EmployeeContact employeecontact)
        {
            try
            {
                db.EmployeeContacts.Add(employeecontact);
                db.SaveChanges();
                return "Data Added in EmployeeContact Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        //Get All Records // Select * from Table
        public IEnumerable<EmployeeContact> Get()
        {
            return db.EmployeeContacts.ToList();
        }

        //Get Single Record // Select * from table where id = ..    (GET)
        public EmployeeContact Get(int id)
        {
            try
            {
                EmployeeContact employeecontact = db.EmployeeContacts.Find(id);
                return employeecontact;
            }
            catch (Exception)
            {
                EmployeeContact employeecontact = null;
                return employeecontact;
            }
        }

        //Update the Record //update table where id =.. or update table where company = ..  (PUT)
        public string Put(int id, EmployeeContact employeecontact)
        {
            try
            {
                var employeecontact_ = db.EmployeeContacts.Find(id);
                employeecontact_.comp_id= employeecontact.comp_id;
                employeecontact_.emp_id = employeecontact.emp_id;
                employeecontact_.currAddress = employeecontact.currAddress;
                employeecontact_.perAddress = employeecontact.perAddress;
                employeecontact_.mobNo = employeecontact.mobNo;
                employeecontact_.mobNo1 = employeecontact.mobNo1;
                employeecontact_.whatsupNo = employeecontact.whatsupNo;
                employeecontact_.primEmail = employeecontact.primEmail;
                employeecontact_.alterEmail = employeecontact.alterEmail;
                employeecontact_.fatherName = employeecontact.fatherName;
                employeecontact_.montherName = employeecontact.montherName;
                employeecontact_.isActive = employeecontact.isActive;
                employeecontact_.create_dtm = employeecontact.create_dtm;
                employeecontact_.update_dtm = employeecontact.update_dtm;
                employeecontact_.created_by = employeecontact.created_by;
                employeecontact_.updated_by = employeecontact.updated_by;

                db.Entry(employeecontact_).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Record Updated in EmployeeContact Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        //Delete the Record //delete from table where id = .. (DELETE)
        public string Delete(int id)
        {
            try
            {
                EmployeeContact employeecontact = db.EmployeeContacts.Find(id);
                db.EmployeeContacts.Remove(employeecontact);
                db.SaveChanges();
                return "Record Deleted from EmployeeContact Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}