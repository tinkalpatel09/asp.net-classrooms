using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using lab3.Models;

namespace lab3.Controllers
{
    public class ProjectAssignmentsController : Controller
    {
        private StudentProjectsDBEntities db = new StudentProjectsDBEntities();

        // GET: ProjectAssignments
        public ActionResult Index()
        {
            var projectAssignments = db.ProjectAssignments.Include(p => p.Project).Include(p => p.Student);
            return View(projectAssignments.ToList());
        }

        // GET: ProjectAssignments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectAssignment projectAssignment = db.ProjectAssignments.Find(id);
            if (projectAssignment == null)
            {
                return HttpNotFound();
            }
            return View(projectAssignment);
        }

        // GET: ProjectAssignments/Create
        public ActionResult Create()
        {
            ViewBag.ProjectCode = new SelectList(db.Projects, "ProjectCode", "ProjectTitle");
            ViewBag.StudentNumber = new SelectList(db.Students, "StudentNumber", "FirstName");
            return View();
        }

        // POST: ProjectAssignments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StudentNumber,ProjectCode,AssignedDate,SubmittedDate")] ProjectAssignment projectAssignment)
        {
            if (ModelState.IsValid)
            {
                db.ProjectAssignments.Add(projectAssignment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ProjectCode = new SelectList(db.Projects, "ProjectCode", "ProjectTitle", projectAssignment.ProjectCode);
            ViewBag.StudentNumber = new SelectList(db.Students, "StudentNumber", "FirstName", projectAssignment.StudentNumber);
            return View(projectAssignment);
        }

        // GET: ProjectAssignments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectAssignment projectAssignment = db.ProjectAssignments.Find(id);
            if (projectAssignment == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProjectCode = new SelectList(db.Projects, "ProjectCode", "ProjectTitle", projectAssignment.ProjectCode);
            ViewBag.StudentNumber = new SelectList(db.Students, "StudentNumber", "FirstName", projectAssignment.StudentNumber);
            return View(projectAssignment);
        }

        // POST: ProjectAssignments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StudentNumber,ProjectCode,AssignedDate,SubmittedDate")] ProjectAssignment projectAssignment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(projectAssignment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProjectCode = new SelectList(db.Projects, "ProjectCode", "ProjectTitle", projectAssignment.ProjectCode);
            ViewBag.StudentNumber = new SelectList(db.Students, "StudentNumber", "FirstName", projectAssignment.StudentNumber);
            return View(projectAssignment);
        }

        // GET: ProjectAssignments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectAssignment projectAssignment = db.ProjectAssignments.Find(id);
            if (projectAssignment == null)
            {
                return HttpNotFound();
            }
            return View(projectAssignment);
        }

        // POST: ProjectAssignments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProjectAssignment projectAssignment = db.ProjectAssignments.Find(id);
            db.ProjectAssignments.Remove(projectAssignment);
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
