using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using carwebapplication.Models;

namespace carwebapplication.Controllers
{
    public class UserController : Controller
    {
        //Registration Action
        [HttpGet]
        public ActionResult Registration() {
            return View();
        }

        //Registration Post Action
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registration(User user)
        {
            bool Status = false;
            string message = "";
            if (ModelState.IsValid)
            {
                #region Password hashing
                user.Password = Crypto.Hash(user.Password);
                user.ConformPassword = Crypto.Hash(user.ConformPassword);
                #endregion
                using (CarRentDBEntities dc = new CarRentDBEntities())
                {
                  
                    dc.Users.Add(user);
                    dc.SaveChanges();

                    message = "Registration sucessfully done.";
                    Status = true;
                }

            }
            else { 
            message= "invalid request";
            }
            ViewBag.Message = message;
            ViewBag.Status = Status;

             return View(user);
        }
        //verify
        //login
        [HttpGet]
        public ActionResult Login() {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserLogin login)
        {
            string message = "";
            using (CarRentDBEntities dc = new CarRentDBEntities())
            {
                var v = dc.Users.Where(a => a.Name == login.Name).FirstOrDefault();
                if (v != null)
                {


                }
                else {
                    message = "invalid credential provided";

                }
            }
            ViewBag.Message = message;
                return View();
        }


        //
    }
}