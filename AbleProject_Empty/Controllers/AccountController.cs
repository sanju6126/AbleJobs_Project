using AbleProject_Empty.DBModel;
using AbleProject_Empty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AbleProject_Empty.Controllers
{
    public class AccountController : Controller
    {



        private AbleDBEntities objAbleDBEntities;

        public AccountController()
        {
            objAbleDBEntities = new AbleDBEntities();
        }




        public ActionResult Index()
        {
            return View();
        }

       


        //REGISTER PART
        public ActionResult Register()
        {
            UserModel objUserModel = new UserModel();
            return View(objUserModel);
        }

        [HttpPost]
        public ActionResult Register(UserModel objUserModel)
        {
            if (ModelState.IsValid)
            {
                if(!objAbleDBEntities.Users.Any(model => model.Email == objUserModel.Email))
                {
                    User objUser = new User();
                    objUser.CreatedOn = DateTime.Now;
                    objUser.Email = objUserModel.Email;
                    objUser.FirstName = objUserModel.FirstName;
                    objUser.LastName = objUserModel.LastName;
                    objUser.Password = objUserModel.Password;
                    objUser.CompanyName = objUserModel.CompanyName;

                    objAbleDBEntities.Users.Add(objUser);
                    objAbleDBEntities.SaveChanges();
                    objUserModel.SuccessMessage = "User is Successfully Added";
                    return RedirectToAction("LogIn", "Account");
                }
                else
                {
                    ModelState.AddModelError("Error", "Email Allready Registered");
                    return View();
                }
            }

            return View();
        }





        // GET: Account
        public ActionResult LogIn()
        {
            LoginModel objLoginModel = new LoginModel();

            return View(objLoginModel);
        }

        [HttpPost]
        public ActionResult Login(LoginModel objLoginModel)
        {
            if (objAbleDBEntities.Users.Where(model => model.Email == objLoginModel.Email && model.Password == objLoginModel.Password).FirstOrDefault() == null)
            {
                ModelState.AddModelError("Error", "Invalid Email or Password");
                return View();
                //yaha pe ek view bana ke usko redirect kar skt hai....jaise successfull hua to ...doosra view and unsuccess hua to doosra
            }
            else
            {
                Session["Email"] = objLoginModel.Email;
                return RedirectToAction("Index", "Home");
                //if login is successfull it will redirect us to to the index page of the home controller
            }
        }








        public ActionResult LogOut()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Account");
        }
    }
}