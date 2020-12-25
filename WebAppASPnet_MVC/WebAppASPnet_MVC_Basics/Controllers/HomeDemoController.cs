using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppASPnet_MVC_Basics.Controllers
{
    public class HomeDemoController : Controller
    {
        // GET: HomeDemo
        //public ActionResult Index()
        //{
        //    return View();
        //}
        //public string Index()
        //{
        //    return "Welcome to asp.net mvc Applications. ";
        //}
        //public string Index(int id)
        //{
        //    return ("The value of id = " + id);
        //}
        //public string Index(int id,string name)
        //{
        //    return ("The value of id = " + id + "the name is :" + name);
        //}
        [HttpGet]
        public string Index(int id, string name)
        {
            return ("The value of id = " + id + "the name is :" + Request.QueryString["name"]);
        }
    }
}