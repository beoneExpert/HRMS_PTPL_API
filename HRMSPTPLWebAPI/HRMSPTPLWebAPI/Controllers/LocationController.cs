using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HRMSPTPLWebAPI.Models;

namespace HRMSPTPLWebAPI.Controllers
{
    public class LocationController : ApiController
    {
        HRMS_PTPL_Entties db = new HRMS_PTPL_Entties();

        //Add Post Request
        public string Post(Location location)
        {
            try
            {
                db.Locations.Add(location);
                db.SaveChanges();
                return "Data Added in Location Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        //Get All Records
        public IEnumerable<Location> Get()
        {
            return db.Locations.ToList();
        }

        //Get Single Record
        public Location Get(int id)
        {
            try
            {
                Location location = db.Locations.Find(id);
                return location;
            }
            catch (Exception)
            {
                Location location = null;
                return location;
            }
        }

        //Update the Record
        public string Put(int id, Location location)
        {
            try
            {
                var location_ = db.Locations.Find(id);
                location_.comp_id = location.comp_id;
                location_.name = location.name;
                location_.isActive = location.isActive;
                location_.create_dtm = location.create_dtm;
                location_.update_dtm = location.update_dtm;
                location_.created_by = location.created_by;
                location_.updated_by = location.updated_by;
                db.Entry(location_).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Record Updated in Location Table";
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
                Location location = db.Locations.Find(id);
                db.Locations.Remove(location);
                db.SaveChanges();
                return "Record Deleted from Location Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
