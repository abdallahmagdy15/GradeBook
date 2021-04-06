using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace LastLab.Controllers
{
    public class Instr_CourseController : Controller
    {
    //    private Context db = new Context();

    //    [Auth]
    //    public ActionResult Index()
    //    {
    //        return View();
    //    }

    //    [Auth]

    //    public ActionResult List()
    //    {
    //        return PartialView(db.Courses.ToList());
    //    }
    //    public ActionResult Add()
    //    {
    //        ViewBag.ActionName = "Add";
    //        ViewBag.Depts = db.Departments.ToList();

    //        return PartialView(new Course());
    //    }

    //    [Auth]

    //    [HttpPost]
    //    public ActionResult Add(Course crs, string[] deptsList)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            ViewBag.ActionName = "Add";
    //            ViewBag.Depts = db.Departments.ToList();

    //            return PartialView(crs);
    //        }
    //        else
    //        {
    //            try
    //            {
    //                if (deptsList != null)
    //                {
    //                    var deptsNumbers = Array.ConvertAll(deptsList, s => int.Parse(s));
    //                    var depts = deptsNumbers.ToList<int>();
    //                    crs.Departments = (ICollection<Department>)db.Departments.Where(a => depts.Contains(a.Id)).ToList();
    //                }

    //                db.Courses.Add(crs);
    //                db.SaveChanges();
    //            }
    //            catch (Exception err)
    //            {
    //                throw new Exception("error in adding crs data : " + err);
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
    //        Course st = db.Courses.Find(id);
    //        if (st == null)
    //        {
    //            return HttpNotFound();
    //        }
    //        ViewBag.ActionName = "Edit";
    //        ViewBag.Depts = db.Departments.ToList();

    //        return PartialView("Add", st);
    //    }

    //    [HttpPost]
    //    [Auth]
    //    public ActionResult Edit(Course crs, string[] deptsList)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            var Crs = db.Courses.Find(crs.Id);

    //            if (deptsList != null)
    //            {
    //                var deptNumbers = Array.ConvertAll(deptsList, s => int.Parse(s));
    //                var depts = deptNumbers.ToList<int>();
    //                Crs.Departments.Clear();
    //                db.Departments.Where(a => depts.Contains(a.Id)).ToList().ForEach(d =>
    //                {
    //                    Crs.Departments.Add(d);
    //                });
    //            }
    //            else
    //                Crs.Departments.Clear();

    //            Crs.Name = crs.Name;
    //            db.SaveChanges();
    //            return JavaScript("location.reload(true)");
    //        }
    //        ViewBag.ActionName = "Edit";
    //        ViewBag.Depts = db.Departments.ToList();

    //        return PartialView("Add", crs);
    //    }

    //    [Auth]
    //    public ActionResult Delete(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
    //        }
    //        Course st = db.Courses.Find(id);
    //        if (st == null)
    //        {
    //            return HttpNotFound();
    //        }

    //        try
    //        {
    //            db.Courses.Remove(st);
    //            db.SaveChanges();
    //        }
    //        catch (Exception)
    //        {
    //            throw new Exception("error while removing Course");
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
    //        Course st = db.Courses.Find(id);
    //        if (st == null)
    //        {
    //            return HttpNotFound();
    //        }
    //        return PartialView(st);
    //    }
    }
}