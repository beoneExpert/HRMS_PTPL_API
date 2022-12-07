using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HRMSPTPLWebAPI.Models;

namespace HRMSPTPLWebAPI.Controllers
{
    public class TeamController : ApiController
    {
        HRMS_PTPL_Entties db = new HRMS_PTPL_Entties();

        //Add Post Request
        public string Post(Team team)
        {
            try
            {
                db.Teams.Add(team);
                db.SaveChanges();
                return "Data Added in Team Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        //Get All Records
        public IEnumerable<Team> Get()
        {
            return db.Teams.ToList();
        }

        //Get Single Record
        public Team Get(int id)
        {
            try
            {
                Team team = db.Teams.Find(id);
                return team;
            }
            catch (Exception)
            {
                Team team = null;
                return team;
            }
        }

        //Update the Record
        public string Put(int id, Team team)
        {
            try
            {
                var team_ = db.Teams.Find(id);
                team_.comp_id = team.comp_id;
                team_.name = team.name;
                team_.isActive = team.isActive;
                team_.create_dtm = team.create_dtm;
                team_.update_dtm = team.update_dtm;
                team_.created_by = team.created_by;
                team_.updated_by = team.updated_by;
                db.Entry(team_).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Record Updated in Team Table";
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
                Team team = db.Teams.Find(id);
                db.Teams.Remove(team);
                db.SaveChanges();
                return "Record Deleted from Team Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
