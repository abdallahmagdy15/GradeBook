using LastLab.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Lab6.Controllers
{
    [Authorize(Roles = "Admin")]
    public class Admin_ManageDepartmentController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Department
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            return PartialView(db.Departments.ToList());
        }

        public ActionResult Add()
        {
            ViewBag.ActionName = "Add";
            ViewBag.Crs = db.Courses.ToList();
            return PartialView(new Department());
        }

        [HttpPost]
        public ActionResult Add(Department dept, string[] crsList)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.ActionName = "Add";
                ViewBag.Crs = db.Courses.ToList();
                return PartialView(dept);
            }
            else
            {
                try
                {
                    if (crsList != null)
                    {
                        var crsNumbers = Array.ConvertAll(crsList, s => int.Parse(s));
                        var crs = crsNumbers.ToList<int>();
                        dept.Courses = (ICollection<Course>)db.Courses.Where(a => crs.Contains(a.Id)).ToList();
                    }

                    db.Departments.Add(dept);
                    db.SaveChanges();
                }
                catch (Exception err)
                {
                    throw new Exception("error in adding depts data : " + err);
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
            Department dept = db.Departments.Find(id);
            if (dept == null)
            {
                return HttpNotFound();
            }
            ViewBag.ActionName = "Edit";
            ViewBag.Crs = db.Courses.ToList();

            return PartialView("Add", dept);
        }

        [HttpPost]
        public ActionResult Edit(Department dept, string[] crsList)
        {
            if (ModelState.IsValid)
            {
                var Dept = db.Departments.Find(dept.Id);

                if (crsList != null)
                {
                    var crsNumbers = Array.ConvertAll(crsList, s => int.Parse(s));
                    var crs = crsNumbers.ToList<int>();
                    Dept.Courses.Clear();
                    db.Courses.Where(a => crs.Contains(a.Id)).ToList().ForEach(c =>
                    {
                        Dept.Courses.Add(c);
                    });
                }
                else
                    Dept.Courses.Clear();
                Dept.Name = dept.Name;

                db.SaveChanges();
                return JavaScript("location.reload(true)");
            }

            ViewBag.ActionName = "Edit";
            ViewBag.Crs = db.Courses.ToList();

            return PartialView("Add", dept);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Department dept = db.Departments.Find(id);
            if (dept == null)
            {
                return HttpNotFound();
            }

            try
            {
                db.Departments.Remove(dept);
                db.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("error while removing Department");
            }
            return JavaScript("location.reload(true)");
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Department dept = db.Departments.Find(id);
            if (dept == null)
            {
                return HttpNotFound();
            }
            return PartialView(dept);
        }
    }
}
