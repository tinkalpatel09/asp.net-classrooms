using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using loginproject.Models;

namespace loginproject.Controllers
{
    public class HomeController : Controller
    {
        LoginDBEntities db = new LoginDBEntities();
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult checkuser(string userdata) {
            System.Threading.Thread.Sleep(200);
            var seachdata = db.Users.Where(x => x.Username == userdata).SingleOrDefault();
            if (seachdata != null)
            {
                return Json(1);
            }
            else {
                return Json(0);
            }
        
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
            LoginDBEntities usersEntities = new LoginDBEntities();
            usersEntities.Users.Add(user);
            usersEntities.SaveChanges();
            string message = string.Empty;
            
            message = "Registration successful.\\nUser Id: " + user.UserId.ToString();
            ViewBag.Message = message;

            return View(user);
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
    }
}