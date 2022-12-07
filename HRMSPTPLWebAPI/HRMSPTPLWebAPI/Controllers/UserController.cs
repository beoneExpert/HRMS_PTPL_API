using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HRMSPTPLWebAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace HRMSPTPLWebAPI.Controllers
{
    public class UserController : ApiController
    {
        HRMS_PTPL_Entties db = new HRMS_PTPL_Entties();

        //Add Post Request
        public string Post(User user)
        {
            try
            {
                db.Users.Add(user);
                db.SaveChanges();
                return "Data Added in User Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }            
        }

        //Get All Records
        public IEnumerable<User> Get()
        {
            return db.Users.ToList();
        }

        //Get Single Record
        public User Get(int id)
        {
            try
            {
                User user = db.Users.Find(id);
                return user;
            }
            catch (Exception)
            {
                User user = null;
                return user;
            }           
        }

        //Update the Record
        public string Put(int id, User user)
        {
            try
            {
                var user_ = db.Users.Find(id);
                user_.uname = user.uname;
                user_.upass = user.upass;
                user_.email = user.email;
                user_.mobile = user.mobile;
                user_.rp_id = user.rp_id;
                user_.comp_id = user.comp_id;
                user_.isActive = user.isActive;
                user_.create_dtm = user.create_dtm;
                user_.update_dtm = user.update_dtm;
                user_.created_by = user.created_by;
                user_.updated_by = user.updated_by;
                db.Entry(user_).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Record Updated in User Table";
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
                User user = db.Users.Find(id);
                db.Users.Remove(user);
                db.SaveChanges();
                return "Record Deleted from User Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }            
        }
    }
}
