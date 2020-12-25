using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using exampleregistration.Models;

namespace exampleregistration.Controllers
{
    public class HomeController : Controller
    {
        private CarRentalSystemDBEntities5 db = new CarRentalSystemDBEntities5();
        public ActionResult Index()
        {
            
            return View(db.Customers.ToList());
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Customer reg)
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(reg);
                db.SaveChanges();
                return RedirectToAction("Login");
            }
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Customer user)
        {
            if (ModelState.IsValid)
            {
                if (ValidateUser(user.Username, user.Password))
                {
                    FormsAuthentication.SetAuthCookie(user.Username, false);
                    return RedirectToAction("viewcar", "Cars");
                }
                else
                {
                    
                    ModelState.AddModelError("", "Invalid username or password");
                }
            }
            return View();
        }

        private bool ValidateUser(string userName, string password)
        {
            bool isValid = false;

            using (var db = new CarRentalSystemDBEntities5())
            {
                var user = db.Customers.FirstOrDefault(u => u.Username == userName);
                if (user != null)
                {
                    if (user.Password == password)
                    {
                        Session["Customer_Id"] = user.Customer_Id;
                        Session["FirstName"] = user.FirstName;
                        Session["LastName"] = user.LastName;
                        Session["UserName"] = user.Username;
                        Session["Email"] = user.Email;
                        Session["Phonenumber"] = user.Phonenumber;

                        isValid = true;
                    }
                }
            }
            return isValid;
        }

      

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon(); // it will clear the session at the end of request
            return RedirectToAction("Index", "User");
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}