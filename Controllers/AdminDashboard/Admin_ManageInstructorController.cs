
using LastLab.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace LastLab.Controllers
{
    [Authorize(Roles = "Admin")]
    public class Admin_ManageInstructorController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Instructor

        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult List()
        {
            return PartialView(db.Instructors.ToList());
        }

        
        public ActionResult Add()
        {
            try
            {
                var depts = db.Departments.ToList();
                ViewBag.DeptId = new SelectList(depts, "Id", "Name");
            }
            catch (Exception)
            {
                throw;
            }
            ViewBag.ActionName = "Add";
            return PartialView(new Instructor());
        }

        [HttpPost]
        
        public ActionResult Add(Instructor st)
        {
            if (!ModelState.IsValid)
            {
                try
                {
                    var depts = db.Departments.ToList();
                    ViewBag.DeptId = new SelectList(depts, "Id", "Name");
                }
                catch (Exception)
                {
                    throw;
                }
                ViewBag.ActionName = "Add";
                return PartialView(st);
            }
            else
            {
                try
                {
                    db.Instructors.Add(st);
                    db.SaveChanges();
                }
                catch (Exception err)
                {
                    throw new Exception("error in adding Instructor data : " + err);
                }
            }
            return JavaScript("location.reload(true)");
        }

        
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Instructor st = db.Instructors.Find(id);
            if (st == null)
            {
                return HttpNotFound();
            }
            try
            {
                var depts = db.Departments.ToList();
                ViewBag.DeptId = new SelectList(depts, "Id", "Name");

            }
            catch (Exception)
            {
                throw;
            }
            ViewBag.ActionName = "Edit";
            return PartialView("Add", st);
        }

        [HttpPost]
        
        public ActionResult Edit(Instructor st, string[] crsList)
        {
            if (ModelState.IsValid)
            {
                var std = db.Instructors.Find(st.Id);
                std.FullName = st.FullName;
                std.Age = st.Age;
                std.Gender = st.Gender;
                std.Dept = db.Departments.Find(st.DeptId);
                db.SaveChanges();

                return JavaScript("location.reload(true)");
            }
            try
            {
                var depts = db.Departments.ToList();
                ViewBag.DeptId = new SelectList(depts, "Id", "Name");

                ViewBag.Crs = db.Courses.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            ViewBag.ActionName = "Edit";
            return PartialView("Add", st);
        }

        
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Instructor st = db.Instructors.Find(id);
            if (st == null)
            {
                return HttpNotFound();
            }

            try
            {
                db.Instructors.Remove(st);
                db.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("error while removing Instructor");
            }
            return JavaScript("location.reload(true)");
        }

        
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Instructor st = db.Instructors.Find(id);
            if (st == null)
            {
                return HttpNotFound();
            }
            return PartialView(st);
        }
    }
}