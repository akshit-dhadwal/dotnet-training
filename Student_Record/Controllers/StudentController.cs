using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Caching.Memory;
using Student_Record.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_Record.Controllers
{
    public class StudentController : Controller
    {
        static IList<Student> studentList = new List<Student>
        {
            new Student() {
                Roll = 1,
                Name = "AKSHIT",
                Age = 15,
            },
            new Student() {
                Roll = 2,
                Name = "AJAY",
                Age = 16,
            },
            new Student() {
                Roll = 3,
                Name = "ABHISHEK",
                Age = 17,
            },
            new Student() {
                Roll = 4,
                Name = "PARAS",
                Age = 18,
            },
        };
        
        public IActionResult Insert()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Insert(Student st)
        {
            studentList.Add(st);
            return RedirectToAction("StudentDetail");
        }
        public IActionResult StudentDetail()
        {
            
            return View(studentList.OrderBy(s => s.Roll).ToList());

        }

        

        public IActionResult Edit(int id)
        {

            var s = studentList.Where(s => s.Roll == id).FirstOrDefault();
            return View(s);
        }

        [HttpPost]
        public IActionResult Edit(Student st)
        {
            var student = studentList.Where(student=>student.Roll == st.Roll).FirstOrDefault();
            studentList.Remove(student);
            studentList.Add(st);
            return RedirectToAction("StudentDetail");
        }


        public IActionResult Delete(int id)
        {

            var s = studentList.Where(s => s.Roll == id).FirstOrDefault();
            return View(s);
        }
        [HttpPost]
        public IActionResult Delete(Student st)
        {
            var student = studentList.Where(student => student.Roll == st.Roll).FirstOrDefault();
            studentList.Remove(student);
            return RedirectToAction("StudentDetail");
        }
    }
}
