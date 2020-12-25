using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using exampleregistration.Models;

namespace exampleregistration.Controllers
{
    public class UserController : Controller
    {
        CarRentalSystemDBEntities5 db = new CarRentalSystemDBEntities5();
        // GET: User
        public ActionResult Index(int ?page)
        {
            int pagesize = 9, pageindex = 1;
            pageindex = page.HasValue ? Convert.ToInt32(page) : 1;
            var list = db.Cars.Where(x => x.Available == "yes").ToList();
            IPagedList<Car> stu = list.ToPagedList(pageindex, pagesize);

            return View(stu);
        }
       
    }
}