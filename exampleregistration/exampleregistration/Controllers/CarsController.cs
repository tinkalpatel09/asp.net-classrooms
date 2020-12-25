using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using exampleregistration.Models;
using PagedList;

namespace exampleregistration.Controllers
{
 
    public class CarsController : Controller
    {
        CarRentalSystemDBEntities5 db = new CarRentalSystemDBEntities5();
        // GET: Cars
        [HttpGet]
        public ActionResult Addnewcar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Addnewcar(Car d,HttpPostedFileBase imgfile)
        {
            Car di = new Car();
            string path = uploadimage(imgfile);
            if (path.Equals("-1"))
            {

            }
            else {
                di.CarType = d.CarType;
                di.CarModel = d.CarModel;
                di.CarBrand = d.CarBrand;
                di.prize = d.prize;
                di.Available = d.Available;
                di.ImagePath = path;
                db.Cars.Add(di);
                db.SaveChanges();
                ViewBag.msg = "data added...";
                
            }
            ModelState.Clear();
            return View();
        }
        public string uploadimage(HttpPostedFileBase file)
        {
            Random r = new Random();
            string path = "-1";
            int random = r.Next();
            if (file != null && file.ContentLength > 0)
            {
                string extension = Path.GetExtension(file.FileName);
                if (extension.ToLower().Equals(".jpg") || extension.ToLower().Equals(".jpeg") || extension.ToLower().Equals(".png"))
                {
                    try
                    {
                        path = Path.Combine(Server.MapPath("~/Content/upload"), random + Path.GetFileName(file.FileName));
                        file.SaveAs(path);
                        path = "~/Content/upload/" + random + Path.GetFileName(file.FileName);
                        //    ViewBag.Message = "File uploaded successfully";
                    }

                    catch (Exception ex)
                    {
                        path = "-1";
                    }
                }
                else
                {
                    Response.Write("<script>alert('Only jpg ,jpeg or png formats are acceptable....'); </script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Please select a file'); </script>");
                path = "-1";
            }
            return path;
        }

        [HttpGet]
        public ActionResult viewcar(int? page) {

            int pagesize = 9, pageindex = 1;
            pageindex = page.HasValue ? Convert.ToInt32(page) : 1;
            var list = db.Cars.Where(x => x.Available == "yes").ToList();
            IPagedList<Car> stu = list.ToPagedList(pageindex, pagesize);



            if (TempData["Bookcar"] != null)
            {
                float x = 0;
                List<Bookcar> li2 = TempData["Bookcar"] as List<Bookcar>;
                foreach (var item in li2)
                {
                    x += item.bill;
                }
                TempData["bill"] = x;
            }
            TempData.Keep();



            return View(stu);
           

           

        }

        public ActionResult EditCars(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car caredit = db.Cars.Find(id);
            if (caredit == null)
            {
                return HttpNotFound();
            }
            return View(caredit);
        }

        // POST: /Movies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditCars([Bind(Include = "CarId,CarType,CarModel,CarBrand,prize,ImagePath")] Car caredit)
        {
            if (ModelState.IsValid)
            {

                db.Entry(caredit).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("viewcar");
            }
            return View(caredit);
        }
        public ActionResult BookaCar(int? Id)
        {
            Car c = db.Cars.Where(x => x.CarId == Id).SingleOrDefault();
            return View(c);
        }
        List<Bookcar> li = new List<Bookcar>();

        [HttpPost]
        public ActionResult BookaCar(Car pi,int Id, string picuplocation,DateTime startdate, DateTime enddate,int Age)
        {
            if (Session["Customer_Id"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                Car b = db.Cars.Where(x => x.CarId == Id).SingleOrDefault();

                Bookcar bk = new Bookcar();

                bk.Prize = b.prize;
                bk.PickupLoc = picuplocation;
                bk.carid = b.CarId;
                bk.cartype = b.CarType;
                bk.custid = Convert.ToInt32(Session["Customer_Id"].ToString());
                bk.custname = Convert.ToString(Session["FirstName"]);
                bk.age = Age;
                bk.StartDate = Convert.ToDateTime(startdate);
                bk.EndDate = Convert.ToDateTime(enddate);
                DateTime sdate = bk.StartDate;
                DateTime edate = bk.EndDate;
             
                double difference = (edate - sdate).TotalDays;
                bk.bill = (float)b.prize * (float)difference;
               
                ViewBag.msg = "data added...";
                if (TempData.Peek("Bookcar") == null)
                {
                    li.Add(bk);
                    TempData["Bookcar"] = li;

                }
                else
                {
                    List<Bookcar> li2 = TempData["Bookcar"] as List<Bookcar>;
                    li2.Add(bk);
                    TempData["Bookcar"] = li2;
                }

                TempData.Keep("Bookcar");


                return RedirectToAction("checkout");
            }

        }
        public ActionResult remove(int? id)
        {
            List<Bookcar> li2 = TempData["Bookcar"] as List<Bookcar>;
            Bookcar b = li2.Where(x => x.carid == id).SingleOrDefault();
            li2.Remove(b);
            float h = 0;
            foreach (var item in li2)
            {
                h += item.bill;
            }
            TempData["bill"] = h;

            return RedirectToAction("checkout");
        }

        public ActionResult checkout()
        {
          
            TempData.Keep();


            return View();
        }
        [HttpPost]
        public ActionResult checkout(BookingDetail bkd)
        {
            List<Bookcar> li = TempData["Bookcar"] as List<Bookcar>;

            // TempData.Keep("Bookcar");

            BillingDetail bd = new BillingDetail();
            bd.BillDate = System.DateTime.Now;
            bd.TotalAmount = Convert.ToDouble(TempData["bill"]);
            bd.Customer_Id = Convert.ToInt32(Session["Customer_Id"].ToString());
            db.BillingDetails.Add(bd);
            db.SaveChanges();

            foreach (var item in li)
            {
                BookingDetail bdetail = new BookingDetail();
                bdetail.CarId = item.carid;
                bdetail.Billid = bd.Billid;
                bdetail.Prize = item.bill;
                bdetail.StartDate = item.StartDate;
                bdetail.EndDate = item.EndDate;
                bdetail.PickupLoc = item.PickupLoc;
              
                db.BookingDetails.Add(bdetail);
                db.SaveChanges();
            }
            TempData.Remove("bill");
            TempData.Remove("Bookcar");

            TempData["msg"] = "Transaction completed.....";
           
            TempData.Keep();
            return RedirectToAction("Index", "User");
           // return RedirectToAction("User","Index");
            //return View("viewcar");
        }


        public ActionResult Contactdetails()
        {
           
            return View();
        }

    }
}