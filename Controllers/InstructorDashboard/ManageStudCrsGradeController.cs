
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LastLab.Controllers
{
    public class Instr_StudCrsGradeController : Controller
    {
    //    private Context db = new Context();

    //    // GET: StudCrsGrade
    //    [Auth]
    //    public ActionResult Index()
    //    {
    //        ViewBag.Depts = db.Departments.ToList();
    //        return View();
    //    }

    //    [Auth]
    //    public ActionResult UpdateStudGrade(StudCrsGrade studCrsGrade)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            var stcrs =  db.StudCrsGrade.Where(a => a.StdId == studCrsGrade.StdId && a.CrsId == studCrsGrade.CrsId).FirstOrDefault();
    //            if(stcrs == null)
    //            {
    //                studCrsGrade.Course = db.Courses.Find(studCrsGrade.CrsId);
    //                studCrsGrade.Student = db.Students.Find(studCrsGrade.StdId);

    //                db.StudCrsGrade.Add(studCrsGrade);
    //            }
    //            else
    //            {
    //                stcrs.Grade = studCrsGrade.Grade;
    //            }
    //            db.SaveChanges();
    //            return Content("Grade Updated!");
    //        }
    //        return Content("An Error Occurred!");
    //    }

    //    [Auth]
    //    public ActionResult GetStudentsGrades(int? DeptId)
    //    {
    //        if (DeptId != null)
    //        {
    //            List<Student> AllDeptStudents = db.Departments.Find(DeptId).Students.ToList();
    //            //IEnumerable<StdGrade> DeptStudentsWithGrades =
    //            //    from st in AllDeptStudents
    //            //    join stCrs in db.StudCrsGrade.ToList() on
    //            //    st.Id equals stCrs.StdId into stGrades
    //            //    from x in stGrades.DefaultIfEmpty()
    //            //    select new
    //            //    StdGrade
    //            //    {
    //            //        Id = st.Id,
    //            //        Name = st.Name,
    //            //        CrsId = (x == null ? 0 : x.CrsId),
    //            //        Grade = (x == null ? 0 : x.Grade)
    //            //    };
    //            ViewBag.Crs = db.Departments.Find(DeptId).Courses.ToList();
    //            return PartialView("StudentsGrades", AllDeptStudents);
    //        }
    //        return Content("An Error Occurred! Please Try Again Later..");
    //    }

    //    [Auth]
    //    public ActionResult GetStudentCrsGrade(int StdId , int selectedCrs)
    //    {
    //        var st = db.StudCrsGrade.Where(a => a.StdId == StdId && a.CrsId == selectedCrs).FirstOrDefault();
    //        if(st == null)
    //        {
    //            return Json(new { StdId=StdId, Grade=0}, JsonRequestBehavior.AllowGet);
    //        }
    //        else
    //        {
    //            return Json(new { StdId=StdId, Grade = st.Grade }, JsonRequestBehavior.AllowGet); ;
    //        }
    //    }
    }
}