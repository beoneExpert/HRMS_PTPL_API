using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HRMSPTPLWebAPI.Models;

namespace HRMSPTPLWebAPI.Controllers
{
    public class PermissionController : ApiController
    {
        HRMS_PTPL_Entties db = new HRMS_PTPL_Entties();

        //Add Post Request
        public string Post(Permission permission)
        {
            try
            {
                db.Permissions.Add(permission);
                db.SaveChanges();
                return "Data Added in Permission Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        //Get All Records
        public IEnumerable<Permission> Get()
        {
            return db.Permissions.ToList();
        }

        //Get Single Record
        public Permission Get(int id)
        {
            try
            {
                Permission permission = db.Permissions.Find(id);
                return permission;
            }
            catch (Exception)
            {
                Permission permission = null;
                return permission;
            }
        }

        //Update the Record
        public string Put(int id, Permission permission)
        {
            try
            {
                var permission_ = db.Permissions.Find(id);
                permission_.comp_id = permission.comp_id;
                permission_.name = permission.name;
                permission_.url = permission.url;
                permission_.type = permission.type;
                permission_.isActive = permission.isActive;
                permission_.create_dtm = permission.create_dtm;
                permission_.update_dtm = permission.update_dtm;
                permission_.created_by = permission.created_by;
                permission_.updated_by = permission.updated_by;
                permission_.isMobile = permission.isMobile;
                db.Entry(permission_).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Record Updated in Permission Table";
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
                Permission permission = db.Permissions.Find(id);
                db.Permissions.Remove(permission);
                db.SaveChanges();
                return "Record Deleted from Permission Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
