using DBMigration_test.Context;
using DBMigration_test.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace DBMigration_test.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentRepository _studentRepository = null;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public StudentController(StudentRepository studentRepository, IWebHostEnvironment webHostEnvironment)
        {
            _studentRepository = studentRepository;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAllStudents()
        {
           
            return View(_studentRepository.GetAllStudents());
        }

        public IActionResult AddNewStudent()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult AddNewStudent(Studentcs studentcs)
        {
            if (ModelState.IsValid)
            {
                if (studentcs.CoverPhoto != null)
                {
                    string folder = "cover/students";
                    folder += Guid.NewGuid().ToString() + "-" + studentcs.CoverPhoto.FileName;       //for uplodaing multiple images

                    studentcs.CoverImageUrl = "/" + folder;
                    string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folder);    // used to recognise path during deployment 

                    studentcs.CoverPhoto.CopyTo(new FileStream(serverFolder, FileMode.Create));
                }
                _studentRepository.AddNewStudent(studentcs);
                
               return RedirectToAction("AddNewStudent", "Student");
                
            }
           
            return View();

        }
    }
}

