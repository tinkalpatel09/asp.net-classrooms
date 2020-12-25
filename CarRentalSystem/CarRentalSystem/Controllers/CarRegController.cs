﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarRentalSystem.Models;

namespace CarRentalSystem.Controllers
{
    public class CarRegController : Controller
    {
        private CarRentDBEntities1 db = new CarRentDBEntities1();

        // GET: CarReg
        public ActionResult Index()
        {
            return View(db.carregs.ToList());
        }

        // GET: CarReg/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            carreg carreg = db.carregs.Find(id);
            if (carreg == null)
            {
                return HttpNotFound();
            }
            return View(carreg);
        }

        // GET: CarReg/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarReg/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,CarModel,CarBrand,CarType,Available")] carreg carreg)
        {
            if (ModelState.IsValid)
            {
                db.carregs.Add(carreg);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(carreg);
        }

        // GET: CarReg/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            carreg carreg = db.carregs.Find(id);
            if (carreg == null)
            {
                return HttpNotFound();
            }
            return View(carreg);
        }

        // POST: CarReg/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,CarModel,CarBrand,CarType,Available")] carreg carreg)
        {
            if (ModelState.IsValid)
            {
                db.Entry(carreg).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(carreg);
        }

        // GET: CarReg/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            carreg carreg = db.carregs.Find(id);
            if (carreg == null)
            {
                return HttpNotFound();
            }
            return View(carreg);
        }

        // POST: CarReg/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            carreg carreg = db.carregs.Find(id);
            db.carregs.Remove(carreg);
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
