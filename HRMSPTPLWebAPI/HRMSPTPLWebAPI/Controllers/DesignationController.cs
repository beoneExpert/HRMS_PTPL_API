using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HRMSPTPLWebAPI.Models;

namespace HRMSPTPLWebAPI.Controllers
{
    public class DesignationController : ApiController
    {
        HRMS_PTPL_Entties db = new HRMS_PTPL_Entties();

        //Add Post Request
        public string Post(Designation designation)
        {
            try
            {
                db.Designations.Add(designation);
                db.SaveChanges();
                return "Data Added in Designation Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }           
        }

        //Get All Records
        public IEnumerable<Designation> Get()
        {
            return db.Designations.ToList();
        }

        //Get Single Record
        public Designation Get(int id)
        {
            try
            {
                Designation designation = db.Designations.Find(id);
                return designation;
            }
            catch (Exception)
            {
                Designation designation = null;
                return designation;
            }          
        }

        //Update the Record
        public string Put(int id, Designation designation)
        {
            try
            {
                var designation_ = db.Designations.Find(id);
                designation_.comp_id = designation.comp_id;
                designation_.name = designation.name;
                designation_.isActive = designation.isActive;
                designation_.create_dtm = designation.create_dtm;
                designation_.update_dtm = designation.update_dtm;
                designation_.created_by = designation.created_by;
                designation_.updated_by = designation.updated_by;

                db.Entry(designation_).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Record Updated in Designation Table";
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
                Designation designation = db.Designations.Find(id);
                db.Designations.Remove(designation);
                db.SaveChanges();
                return "Record Deleted from Designation Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }           
        }
    }
}
