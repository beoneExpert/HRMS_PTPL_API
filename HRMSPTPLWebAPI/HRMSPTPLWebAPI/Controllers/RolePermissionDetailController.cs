using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HRMSPTPLWebAPI.Models;

namespace HRMSPTPLWebAPI.Controllers
{
    public class RolePermissionDetailControllersss : ApiController
    {
        HRMS_PTPL_Entties db = new HRMS_PTPL_Entties();
        
        //Add Post Request
        //public string Post(RolePermissionDetail rolePermissionDetail)
        //{
        //    try
        //    {
        //        db.RolePermissionDetails.Add(rolePermissionDetail);
        //        db.SaveChanges();
        //        return "Data Added in RolePermissionDetails Table";
        //    }
        //    catch (Exception ex)
        //    {
        //        return ex.ToString();
        //    }            
        //}

        ////Get All Records
        //public IEnumerable<RolePermissionDetail> Get()
        //{            
        //    return db.RolePermissionDetails.ToList();
        //}

        ////Get Single Record
        //public RolePermissionDetail Get(int id)
        //{
        //    try
        //    {
        //        RolePermissionDetail rolePermissionDetail = db.RolePermissionDetails.Find(id);
        //        return rolePermissionDetail;
        //    }
        //    catch (Exception)
        //    {
        //        RolePermissionDetail rolePermissionDetail = null;
        //        return rolePermissionDetail;
        //    }
        //}

        ////Update the Record
        //public string Put(int id, RolePermissionDetail rolePermissionDetail)
        //{
        //    try
        //    {
        //        var rolePermissionDetail_ = db.RolePermissionDetails.Find(id);
        //        rolePermissionDetail_.comp_id = rolePermissionDetail.comp_id;
        //        rolePermissionDetail_.rp_id = rolePermissionDetail.rp_id;
        //        rolePermissionDetail_.name = rolePermissionDetail.name;
        //        rolePermissionDetail_.perm_id = rolePermissionDetail.perm_id;
        //        rolePermissionDetail_.role_id = rolePermissionDetail.role_id;
        //        rolePermissionDetail_.isActive = rolePermissionDetail.isActive;
        //        rolePermissionDetail_.create_dtm = rolePermissionDetail.create_dtm;
        //        rolePermissionDetail_.update_dtm = rolePermissionDetail.update_dtm;
        //        rolePermissionDetail_.created_by = rolePermissionDetail.created_by;
        //        rolePermissionDetail_.updated_by = rolePermissionDetail.updated_by;
        //        db.Entry(rolePermissionDetail_).State = System.Data.Entity.EntityState.Modified;
        //        db.SaveChanges();
        //        return "Record Updated in RolePermissionDetails Table";
        //    }
        //    catch (Exception ex)
        //    {
        //        return ex.ToString();
        //    }
        //}

        ////Delete the Record
        //public string Delete(int id)
        //{
        //    try
        //    {
        //        RolePermissionDetail rolePermissionDetail = db.RolePermissionDetails.Find(id);
        //        db.RolePermissionDetails.Remove(rolePermissionDetail);
        //        db.SaveChanges();
        //        return "Record Deleted from RolePermissionDetails Table";
        //    }
        //    catch (Exception ex)
        //    {
        //        return ex.ToString();
        //    }            
        //}
    }
}
