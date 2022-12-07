using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HRMSPTPLWebAPI.Models;

namespace HRMSPTPLWebAPI.Controllers
{
    public class RolePermissionController : ApiController
    {
        HRMS_PTPL_Entties db = new HRMS_PTPL_Entties();

        //Add Post Request
        public string Post(RolePermission rolePermission)
        {
            try
            {
                db.RolePermissions.Add(rolePermission);
                db.SaveChanges();
                return "Data Added in RolePermission Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }           
        }

        //Get All Records
        public IEnumerable<RolePermission> Get()
        {
            return db.RolePermissions.ToList();
        }

        //Get Single Record
        public RolePermission Get(int id)
        {
            try
            {
                RolePermission rolePermission = db.RolePermissions.Find(id);
                return rolePermission;
            }
            catch (Exception)
            {
                RolePermission rolePermission = null;
                return rolePermission;
            }
        }

        //Update the Record
        public string Put(int id, RolePermission rolePermission)
        {
            try
            {
                var rolePermission_ = db.RolePermissions.Find(id);
                rolePermission_.comp_id = rolePermission.comp_id;
                rolePermission_.name = rolePermission.name;
                db.Entry(rolePermission_).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Record Updated in RolePermission Table";
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
                RolePermission rolePermission = db.RolePermissions.Find(id);
                db.RolePermissions.Remove(rolePermission);
                db.SaveChanges();
                return "Record Deleted from RolePermission Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
