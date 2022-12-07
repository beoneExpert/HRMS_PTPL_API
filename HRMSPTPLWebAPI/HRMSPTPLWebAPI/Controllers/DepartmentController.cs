using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HRMSPTPLWebAPI.Models;

namespace HRMSPTPLWebAPI.Controllers
{
    public class DepartmentController : ApiController
    {
        HRMS_PTPL_Entties db = new HRMS_PTPL_Entties();

        //Add Post Request
        public string Post(Department department)
        {
            try
            {
                db.Departments.Add(department);
                db.SaveChanges();
                return "Data Added in Department Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }           
        }

        //Get All Records
        public IEnumerable<Department> Get()
        {
            return db.Departments.ToList();
        }

        //Get Single Record
        public Department Get(int id)
        {
            try
            {
                Department department = db.Departments.Find(id);
                return department;
            }
            catch (Exception)
            {
                Department department = null;
                return department;
            }            
        }

        //Update the Record
        public string Put(int id, Department department)
        {
            try
            {
                var department_ = db.Departments.Find(id);
                department_.comp_id = department.comp_id;
                department_.name = department.name;
                department_.isActive = department.isActive;
                department_.create_dtm = department.create_dtm;
                department_.update_dtm = department.update_dtm;
                department_.created_by = department.created_by;
                department_.updated_by = department.updated_by;

                db.Entry(department_).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Record Updated in Department Table";
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
                Department department = db.Departments.Find(id);
                db.Departments.Remove(department);
                db.SaveChanges();
                return "Record Deleted from Department Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }          
        }
    }
}
