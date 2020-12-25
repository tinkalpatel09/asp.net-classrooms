using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using SMTITeacher_CourseManagement.Models;

namespace SMTITeacher_CourseManagement.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
       
      
       
        [HttpPost]
        public ActionResult Index(User users)
        {
           
            return View(users);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //public ActionResult UserLogin(User users)
        //{
        //    ViewBag.Message = "Your Home page.";

        //    if (ModelState.IsValid)
        //    {
        //        //message will collect the String value from the model method.
        //        String message = users.LoginProcess(users.UserName, users.Password);
        //        //RedirectToAction("actionName/ViewName_ActionResultMethodName", "ControllerName");
        //        if (message.Equals("1"))
        //        {
        //            //this will add cookies for the username.
        //            Response.Cookies.Add(new HttpCookie("Users", users.UserName));
        //            //This is a different Controller for the User Homepage. Redirecting after successful process.
        //            return RedirectToAction("Home", "UserHome");
        //        }
        //        else
        //            ViewBag.ErrorMessage = message;
        //    }
        //    return View(users);
        //}


        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                if (ValidateUser(user.UserName, user.Password))
                {
                    FormsAuthentication.SetAuthCookie(user.UserName, false);
                    return RedirectToAction("Index", "CourseAssignments");
                }
                else
                {

                    ModelState.AddModelError("", "Invalid username or password");
                    return RedirectToAction("Index", "Cours");
                }
            }
            return View();
        }

        private bool ValidateUser(string userName, string password)
        {
            bool isValid = false;

            using (var db = new TeacherCourseDBEntities())
            {
                var user = db.Users.FirstOrDefault(u => u.UserName == "4444" );
                if (user != null)
                {
                    if (user.Password == password)
                    {
                        Session["UserName"] = user.UserName;

                        isValid = true;
                    }
                }
                else { 
                
                }
            }
            return isValid;
        }

    }
}