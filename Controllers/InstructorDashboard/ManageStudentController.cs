using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Lab6.Controllers
{
    public class Instr_StudentController : Controller
    {
    //    private Context db = new Context();

    //    // GET: Student
    //    [Auth]
    //    public ActionResult Index()
    //    {
    //        return View();
    //    }

    //    [Auth]
    //    public ActionResult List()
    //    {
    //        return PartialView(db.Students.ToList());
    //    }

    //    [Auth]
    //    public ActionResult Add()
    //    {
    //        try
    //        {
    //            var depts = db.Departments.ToList();
    //            ViewBag.DeptId = new SelectList(depts, "Id", "Name");
    //        }
    //        catch (Exception)
    //        {
    //            throw;
    //        }
    //        ViewBag.ActionName = "Add";
    //        return PartialView(new Student());
    //    }

    //    [HttpPost]
    //    [Auth]
    //    public ActionResult Add(Student st)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            try
    //            {
    //                var depts = db.Departments.ToList();
    //                ViewBag.DeptId = new SelectList(depts, "Id", "Name");
    //            }
    //            catch (Exception)
    //            {
    //                throw;
    //            }
    //            ViewBag.ActionName = "Add";
    //            return PartialView(st);
    //        }
    //        else
    //        {
    //            try
    //            {
    //                db.Students.Add(st);
    //                db.SaveChanges();
    //            }
    //            catch (Exception err)
    //            {
    //                throw new Exception("error in adding student data : " + err);
    //            }
    //        }
    //        return JavaScript("location.reload(true)");
    //    }

    //    [Auth]
    //    public ActionResult Edit(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
    //        }
    //        Student st = db.Students.Find(id);
    //        if (st == null)
    //        {
    //            return HttpNotFound();
    //        }
    //        try
    //        {
    //            var depts = db.Departments.ToList();
    //            ViewBag.DeptId = new SelectList(depts, "Id", "Name");

    //        }
    //        catch (Exception)
    //        {
    //            throw;
    //        }
    //        ViewBag.ActionName = "Edit";
    //        return PartialView("Add", st);
    //    }

    //    [HttpPost]
    //    [Auth]
    //    public ActionResult Edit(Student st, string[] crsList)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            var std = db.Students.Find(st.Id);
    //            std.Name = st.Name;
    //            std.Username = st.Username;
    //            std.Age = st.Age;
    //            std.Gender = st.Gender;
    //            std.Password = st.Password;
    //            std.Email = st.Email;
    //            std.ConfirmPassword = st.Password;
    //            std.Dept = db.Departments.Find(st.DeptId);
    //            db.SaveChanges();

    //            return JavaScript("location.reload(true)");
    //        }
    //        try
    //        {
    //            var depts = db.Departments.ToList();
    //            ViewBag.DeptId = new SelectList(depts, "Id", "Name");

    //            ViewBag.Crs = db.Courses.ToList();
    //        }
    //        catch (Exception)
    //        {
    //            throw;
    //        }
    //        ViewBag.ActionName = "Edit";
    //        return PartialView("Add", st);
    //    }

    //    [Auth]
    //    public ActionResult Delete(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
    //        }
    //        Student st = db.Students.Find(id);
    //        if (st == null)
    //        {
    //            return HttpNotFound();
    //        }

    //        try
    //        {
    //            db.Students.Remove(st);
    //            db.SaveChanges();
    //        }
    //        catch (Exception)
    //        {
    //            throw new Exception("error while removing Student");
    //        }
    //        return JavaScript("location.reload(true)");
    //    }

    //    [Auth]
    //    public ActionResult Details(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
    //        }
    //        Student st = db.Students.Find(id);
    //        if (st == null)
    //        {
    //            return HttpNotFound();
    //        }
    //        return PartialView(st);
    //    }
    }
}