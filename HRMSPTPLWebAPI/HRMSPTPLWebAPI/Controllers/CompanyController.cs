using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HRMSPTPLWebAPI.Models;

namespace HRMSPTPLWebAPI.Controllers
{
    public class CompanyController : ApiController
    {
        HRMS_PTPL_Entties db = new HRMS_PTPL_Entties();

        //Add Post Request  //Insert Into Table (POST)
        public string Post(Company company)
        {
            try
            {
                db.Companies.Add(company);
                db.SaveChanges();
                return "Data Added in Company Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }            
        }

        //Get All Records // Select * from Table
        public IEnumerable<Company> Get()
        {
            return db.Companies.ToList();
        }

        //Get Single Record // Select * from table where id = ..    (GET)
        public Company Get(int id)
        {
            try
            {
                Company company = db.Companies.Find(id);
                return company;
            }
            catch (Exception)
            {
                Company company = null;
                return company;
            }           
        }

        //Update the Record //update table where id =.. or update table where company = ..  (PUT)
        public string Put(int id,Company company)
        {
            try
            {
                var company_ = db.Companies.Find(id);
                company_.name = company.name;
                company_.isActive = company.isActive;
                company_.create_dtm = company.create_dtm;
                company_.update_dtm = company.update_dtm;
                company_.created_by = company.created_by;
                company_.updated_by = company.updated_by;
                db.Entry(company_).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Record Updated in Company Table";
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
                Company company = db.Companies.Find(id);
                db.Companies.Remove(company);
                db.SaveChanges();
                return "Record Deleted from Company Table";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }           
        }
    }
}
