using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HRMSPTPLWebAPI.Models
{
    public class EmployeeInfoController : ApiController
    {
        SecondEntities db = new SecondEntities();

        //Add Post Request  //Insert Into Table (POST)
        public string Post(EmployeeInfo employeeinfo)
        {
            try
            {
                db.EmployeeInfoes.Add(employeeinfo);
                db.SaveChanges();
                return "Data Added in EmployeeInfo Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        //Get All Records // Select * from Table
        public IEnumerable<EmployeeInfo> Get()
        {
            return db.EmployeeInfoes.ToList();
        }

        //Get Single Record // Select * from table where id = ..    (GET)
        public EmployeeInfo Get(int id)
        {
            try
            {
                EmployeeInfo employeeinfo = db.EmployeeInfoes.Find(id);
                return employeeinfo;
            }
            catch (Exception)
            {
                EmployeeInfo employeeinfo = null;
                return employeeinfo;
            }
        }

        //Update the Record //update table where id =.. or update table where company = ..  (PUT)
        public string Put(int id, EmployeeInfo employeeinfo)
        {
            try
            {
                var employeeinfo_ = db.EmployeeInfoes.Find(id);
                employeeinfo_.comp_id = employeeinfo.comp_id;
                employeeinfo_.emp_id = employeeinfo.emp_id;
                employeeinfo_.gender = employeeinfo.gender;
                employeeinfo_.birthDate = employeeinfo.birthDate;
                employeeinfo_.birthPlace = employeeinfo.birthPlace;
                employeeinfo_.bloodGroup = employeeinfo.bloodGroup;
                employeeinfo_.fatherName = employeeinfo.fatherName;
                employeeinfo_.montherName = employeeinfo.montherName;
                employeeinfo_.panNo = employeeinfo.panNo;
                employeeinfo_.aadhaarNo = employeeinfo.aadhaarNo;
                employeeinfo_.esicNo = employeeinfo.esicNo;
                employeeinfo_.pfNo = employeeinfo.pfNo;
                employeeinfo_.pfScheme = employeeinfo.pfScheme;
                employeeinfo_.joiningDate = employeeinfo.joiningDate;
                employeeinfo_.confirmDate = employeeinfo.confirmDate;
                employeeinfo_.resignDate = employeeinfo.resignDate;
                employeeinfo_.status = employeeinfo.status;
                employeeinfo_.isActive = employeeinfo.isActive;
                employeeinfo_.create_dtm = employeeinfo.create_dtm;
                employeeinfo_.update_dtm = employeeinfo.update_dtm;
                employeeinfo_.created_by = employeeinfo.created_by;
                employeeinfo_.updated_by = employeeinfo.updated_by;


                db.Entry(employeeinfo_).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Record Updated in EmployeeInfo Table";
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
                EmployeeInfo employeeinfo = db.EmployeeInfoes.Find(id);
                db.EmployeeInfoes.Remove(employeeinfo);
                db.SaveChanges();
                return "Record Deleted from EmployeeInfo Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
