using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ABC_Employee_Job_Assignment.Models;

namespace ABC_Employee_Job_Assignment.Controllers
{
    public class JobAssignmentsController : Controller
    {
        private EmployeeJobDBEntities1 db = new EmployeeJobDBEntities1();

        // GET: JobAssignments
        public ActionResult Index()
        {
            var jobAssignments = db.JobAssignments.Include(j => j.Employee).Include(j => j.Job);
            return View(jobAssignments.ToList());
        }

        // GET: JobAssignments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobAssignment jobAssignment = db.JobAssignments.Find(id);
            if (jobAssignment == null)
            {
                return HttpNotFound();
            }
            return View(jobAssignment);
        }

        // GET: JobAssignments/Create
        public ActionResult Create()
        {
            ViewBag.EmployeeId = new SelectList(db.Employees, "EmployeeId", "FirstName");
            ViewBag.JobCode = new SelectList(db.Jobs, "JobCode", "ProjectTitle");
            return View();
        }

        // POST: JobAssignments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmployeeId,JobCode,StartingDate,EndingDate")] JobAssignment jobAssignment)
        {
            if (ModelState.IsValid)
            {
                db.JobAssignments.Add(jobAssignment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EmployeeId = new SelectList(db.Employees, "EmployeeId", "FirstName", jobAssignment.EmployeeId);
            ViewBag.JobCode = new SelectList(db.Jobs, "JobCode", "ProjectTitle", jobAssignment.JobCode);
            return View(jobAssignment);
        }

        // GET: JobAssignments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobAssignment jobAssignment = db.JobAssignments.Find(id);
            if (jobAssignment == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmployeeId = new SelectList(db.Employees, "EmployeeId", "FirstName", jobAssignment.EmployeeId);
            ViewBag.JobCode = new SelectList(db.Jobs, "JobCode", "ProjectTitle", jobAssignment.JobCode);
            return View(jobAssignment);
        }

        // POST: JobAssignments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmployeeId,JobCode,StartingDate,EndingDate")] JobAssignment jobAssignment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jobAssignment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EmployeeId = new SelectList(db.Employees, "EmployeeId", "FirstName", jobAssignment.EmployeeId);
            ViewBag.JobCode = new SelectList(db.Jobs, "JobCode", "ProjectTitle", jobAssignment.JobCode);
            return View(jobAssignment);
        }

        // GET: JobAssignments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobAssignment jobAssignment = db.JobAssignments.Find(id);
            if (jobAssignment == null)
            {
                return HttpNotFound();
            }
            return View(jobAssignment);
        }

        // POST: JobAssignments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            JobAssignment jobAssignment = db.JobAssignments.Find(id);
            db.JobAssignments.Remove(jobAssignment);
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
