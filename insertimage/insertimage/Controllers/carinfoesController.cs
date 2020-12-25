using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using insertimage.Models;

namespace insertimage.Controllers
{
    public class carinfoesController : Controller
    {
        private CarRentDBEntities1 db = new CarRentDBEntities1();

        // GET: carinfoes
        public ActionResult Index()
        {
            return View(db.carinfoes.ToList());
        }

        // GET: carinfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            carinfo carinfo = db.carinfoes.Find(id);
            if (carinfo == null)
            {
                return HttpNotFound();
            }
            return View(carinfo);
        }

        // GET: carinfoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: carinfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "carid,CarModel,CarType,Carimage")] carinfo carinfo)
        {
            if (ModelState.IsValid)
            {
                db.carinfoes.Add(carinfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(carinfo);
        }

        // GET: carinfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            carinfo carinfo = db.carinfoes.Find(id);
            if (carinfo == null)
            {
                return HttpNotFound();
            }
            return View(carinfo);
        }

        // POST: carinfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "carid,CarModel,CarType,Carimage")] carinfo carinfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(carinfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(carinfo);
        }

        // GET: carinfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            carinfo carinfo = db.carinfoes.Find(id);
            if (carinfo == null)
            {
                return HttpNotFound();
            }
            return View(carinfo);
        }

        // POST: carinfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            carinfo carinfo = db.carinfoes.Find(id);
            db.carinfoes.Remove(carinfo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
