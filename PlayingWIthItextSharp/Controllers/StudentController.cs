using PlayingWIthItextSharp.Models;
using PlayingWIthItextSharp.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlayingWIthItextSharp.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetReport(Student student)
        {
            StudentReport studentReport = new StudentReport();
            byte[] bytes = studentReport.PrepareReport(GetStudents());
            return File(bytes, "application/pdf");
        }
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            Student student = null;
            for (int i = 0; i < 6; i++)
            {
                student = new Student();
                student.Id = 1;
                student.Name = "Student " + i;
                student.Roll = "Roll" + i;
                students.Add(student);
            }
            return students;
        }
    }
}