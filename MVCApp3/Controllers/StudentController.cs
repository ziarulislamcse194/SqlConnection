using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApp3.Models.Models;
using MVCApp3.BLL.BLL;

namespace MVCApp3.Controllers
{
    public class StudentController : Controller
    {
        StudentManager _studentManager = new StudentManager();
        Student _student = new Student();

        // GET: Student
        public ActionResult Add()
        {
            _student.Id = 1;
            _student.Name = "Koko";
            _studentManager.Add(_student);

            return View();
        }

        public ActionResult Delete()
        {
            _student.Id = 9;
            _studentManager.Delete(_student);

            return View();
        }

        public ActionResult Update()
        {
            _student.Id = 10;
            _student.Name = "coco";
            _studentManager.Update(_student);

            return View();
        }
    }
}