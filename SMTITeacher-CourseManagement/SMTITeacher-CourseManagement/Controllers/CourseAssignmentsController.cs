using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SMTITeacher_CourseManagement.Models;

namespace SMTITeacher_CourseManagement.Controllers
{
    public class CourseAssignmentsController : Controller
    {
        private TeacherCourseDBEntities db = new TeacherCourseDBEntities();

        // GET: CourseAssignments
        public ActionResult Index()
        {
            var courseAssignments = db.CourseAssignments.Include(c => c.Cours).Include(c => c.Employee).Include(c => c.Group);
            return View(courseAssignments.ToList());
        }

        // GET: CourseAssignments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseAssignment courseAssignment = db.CourseAssignments.Find(id);
            if (courseAssignment == null)
            {
                return HttpNotFound();
            }
            return View(courseAssignment);
        }

        // GET: CourseAssignments/Create
        public ActionResult Create()
        {
            ViewBag.CourseCode = new SelectList(db.Courses, "CourseCode", "CourseTitle");
            ViewBag.EmployeeId = new SelectList(db.Employees, "EmployeeId", "FirstName");
            ViewBag.GroupNumber = new SelectList(db.Groups, "GroupNumber", "GroupName");
            return View();
        }

        // POST: CourseAssignments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmployeeId,CourseCode,GroupNumber,AssignedDate")] CourseAssignment courseAssignment)
        {
            if (ModelState.IsValid)
            {
                db.CourseAssignments.Add(courseAssignment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CourseCode = new SelectList(db.Courses, "CourseCode", "CourseTitle", courseAssignment.CourseCode);
            ViewBag.EmployeeId = new SelectList(db.Employees, "EmployeeId", "FirstName", courseAssignment.EmployeeId);
            ViewBag.GroupNumber = new SelectList(db.Groups, "GroupNumber", "GroupName", courseAssignment.GroupNumber);
            return View(courseAssignment);
        }

        // GET: CourseAssignments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseAssignment courseAssignment = db.CourseAssignments.Find(id);
            if (courseAssignment == null)
            {
                return HttpNotFound();
            }
            ViewBag.CourseCode = new SelectList(db.Courses, "CourseCode", "CourseTitle", courseAssignment.CourseCode);
            ViewBag.EmployeeId = new SelectList(db.Employees, "EmployeeId", "FirstName", courseAssignment.EmployeeId);
            ViewBag.GroupNumber = new SelectList(db.Groups, "GroupNumber", "GroupName", courseAssignment.GroupNumber);
            return View(courseAssignment);
        }

        // POST: CourseAssignments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmployeeId,CourseCode,GroupNumber,AssignedDate")] CourseAssignment courseAssignment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(courseAssignment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CourseCode = new SelectList(db.Courses, "CourseCode", "CourseTitle", courseAssignment.CourseCode);
            ViewBag.EmployeeId = new SelectList(db.Employees, "EmployeeId", "FirstName", courseAssignment.EmployeeId);
            ViewBag.GroupNumber = new SelectList(db.Groups, "GroupNumber", "GroupName", courseAssignment.GroupNumber);
            return View(courseAssignment);
        }

        // GET: CourseAssignments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseAssignment courseAssignment = db.CourseAssignments.Find(id);
            if (courseAssignment == null)
            {
                return HttpNotFound();
            }
            return View(courseAssignment);
        }

        // POST: CourseAssignments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CourseAssignment courseAssignment = db.CourseAssignments.Find(id);
            db.CourseAssignments.Remove(courseAssignment);
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
