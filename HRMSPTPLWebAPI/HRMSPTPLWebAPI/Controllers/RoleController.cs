using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HRMSPTPLWebAPI.Models;

namespace HRMSPTPLWebAPI.Controllers
{
    public class RoleController : ApiController
    {
        HRMS_PTPL_Entties db = new HRMS_PTPL_Entties();

        //Add Post Request
        public string Post(Role role)
        {
            try
            {
                db.Roles.Add(role);
                db.SaveChanges();
                return "Data Added in Role Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        //Get All Records
        public IEnumerable<Role> Get()
        {
            return db.Roles.ToList();
        }

        //Get Single Record
        public Role Get(int id)
        {
            try
            {
                Role role = db.Roles.Find(id);
                return role;
            }
            catch (Exception)
            {
                Role role = null;
                return role;
            }
        }

        //Update the Record
        public string Put(int id, Role role)
        {
            try
            {
                var role_ = db.Roles.Find(id);
                role_.comp_id = role.comp_id;
                role_.role1 = role.role1;
                role_.isActive = role.isActive;
                role_.create_dtm = role.create_dtm;
                role_.update_dtm = role.update_dtm;
                role_.created_by = role.created_by;
                role_.updated_by = role.updated_by;
                db.Entry(role_).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Record Updated in Role Table";
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
                Role role = db.Roles.Find(id);
                db.Roles.Remove(role);
                db.SaveChanges();
                return "Record Deleted from Role Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
