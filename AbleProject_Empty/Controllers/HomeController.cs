using AbleProject_Empty.DBModel;
using AbleProject_Empty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AbleProject_Empty.Controllers
{
    public class HomeController : Controller
    {
        private AbleDBEntities objAbleDBEntities;

        public HomeController()
        {
            objAbleDBEntities = new AbleDBEntities();
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PostJob()
        {
            PostJob objPostJobModel = new PostJob();                  //PostJob is basically PostJobModel
            return View(objPostJobModel);
        }

        [HttpPost]
        public ActionResult PostJob(PostJob objPostJobModel)
        {
            JobDetail objNewDetail = new JobDetail();
            objNewDetail.PostedOn = DateTime.Now;
            objNewDetail.JobRole = objPostJobModel.JobRole;
            objNewDetail.JobDescription = objPostJobModel.JobDescription;
            objNewDetail.Phone = objPostJobModel.Phone;
            objNewDetail.Address = objPostJobModel.Address;

            objAbleDBEntities.JobDetails.Add(objNewDetail);
            objAbleDBEntities.SaveChanges();

            return RedirectToAction("Index","Home");
        }

        public ActionResult CompaniesApplied()
        {
            IEnumerable<PostJob> listOfCompanies =
                (from objNewDetail in objAbleDBEntities.JobDetails
                 select new PostJob()
                 {
                     JobId = objNewDetail.JobId,
                     JobDescription = objNewDetail.JobDescription,
                     JobRole = objNewDetail.JobRole,
                     Address = objNewDetail.Address,
                     Phone = objNewDetail.Phone,
                     CreatedOn = objNewDetail.PostedOn

                 }).ToList();


            return View(listOfCompanies);
        }





        //UPLOAD RESUME
        public ActionResult UploadResume()
        {
            ResumeModel objResumeModel = new ResumeModel();
            return View(objResumeModel);
        }

        [HttpPost]
        public ActionResult UploadResume(ResumeModel objResumeModel)
        {
            ResumeDetail objNewResume = new ResumeDetail();
            objNewResume.StudentName = objResumeModel.StudentName;
            objNewResume.Email = objResumeModel.Email;
            objNewResume.Contact = objResumeModel.Contact;
            objNewResume.School = objResumeModel.School;
            objNewResume.PlusTwoPercentage = objResumeModel.PlusTwoPercentage;
            objNewResume.College = objResumeModel.College;
            objNewResume.Branch = objResumeModel.Branch;
            objNewResume.GraduationPercentage = objResumeModel.GraduationPercentage;
            objNewResume.Backlogs = objResumeModel.Backlogs;
            objNewResume.Description = objResumeModel.Description;
            objNewResume.PostedOn = DateTime.Now;

            objAbleDBEntities.ResumeDetails.Add(objNewResume);
            objAbleDBEntities.SaveChanges();

            return RedirectToAction("Index","Home");

        }


        //SHOWING LIST OF RESUMES ON THE SCREEN
        public ActionResult ShowResume()
        {
            IEnumerable<ResumeModel> listOfResume =
                (from objNewResume in objAbleDBEntities.ResumeDetails
                 select new ResumeModel()
                 {
                     StudentId = objNewResume.StudentId,
                     StudentName = objNewResume.StudentName,
                     Email = objNewResume.Email,
                     Contact = objNewResume.Contact,
                     School = objNewResume.School,
                     PlusTwoPercentage = objNewResume.PlusTwoPercentage,
                     College = objNewResume.College,
                     Branch = objNewResume.Branch,
                     GraduationPercentage = objNewResume.GraduationPercentage,
                     Backlogs = objNewResume.Backlogs,
                     Description = objNewResume.Description,
                     PostedOn = objNewResume.PostedOn

                 }).ToList();


            return View(listOfResume);
        }


    }
}