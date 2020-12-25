using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarRentalSystem.Models;

namespace CarRentalSystem.Controllers
{
    public class RentController : Controller
    {
        CarRentDBEntities1 db = new CarRentDBEntities1();
        // GET: Rent
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetCar()
        {
            var car = db.carregs.ToList();
            return Json(car, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult Getid(int id)
        {
            var customer = (from s in db.Customers where s.Cusid == id select s.CustName).ToList();
            return Json(customer, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult Geavil(string carmodel)
        {
            var caravail = (from s in db.carregs where s.CarModel == carmodel select s.Available).FirstOrDefault();
            return Json(caravail, JsonRequestBehavior.AllowGet);
        }
    }
}