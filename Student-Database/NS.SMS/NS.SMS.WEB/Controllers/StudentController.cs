using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
//using NS.EMS.Repository;
using NS.SMS.Business;
using NS.SMS.Model;
using NS.SMS.WEB.Entities;
using System;
using System.IO;

namespace NS.SMS.WEB.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentBusiness _istudentbusiness = null;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public StudentController(IStudentBusiness istudentbusiness ,IWebHostEnvironment webHostEnvironment)
        {
            _istudentbusiness = istudentbusiness;
            _webHostEnvironment = webHostEnvironment;
        }

        //private readonly IStudentRepo _istudentrepo = null;

        //public StudentController(IStudentRepo istudentrepo)
        //{
        //    _istudentrepo = istudentrepo;
        //}

        public IActionResult Create()
        {
           
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(StudentModel studentModel)
        {
            if (ModelState.IsValid)
            {
                //if (studentModel.CoverImageUrl != null)
                //{
                //    string folder = "Student/Cover";
                //    folder += Guid.NewGuid().ToString() + "-" + studentModel.CoverImageUrl.FileName;       //for uplodaing multiple images

                //    studentModel.CoverImageUrl = "/" + folder;

                //    string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folder);    // used to recognise path during deployment 

                //    studentModel.CoverImageUrl.CopyTo(new FileStream(serverFolder, FileMode.Create));
                //}
                _istudentbusiness.AddStudent(studentModel);
                return RedirectToAction("Create", "Student");
            }
            
            return View();
        }

        public IActionResult ShowData()
        {
            
            return View(_istudentbusiness.ShowDetail());
        }



        [HttpGet]
        public IActionResult Update(int Id)
        {
          
            return View(_istudentbusiness.GetById(Id));
        }


        [HttpPost]
        public IActionResult Update(StudentModel studentModel, int Id)
        {
            
            if(ModelState.IsValid)
            {
                _istudentbusiness.Update(studentModel, Id);


                return RedirectToAction("ShowData", "Student");

            }
            else
            {
                return View(studentModel);
            }
        }

        //[HttpGet]
        //public IActionResult Delete(int Studentid)
        //{

        //    return View(_istudentbusiness.GetById(Studentid));
        //}

        //[HttpPost]
        public IActionResult Delete(StudentModel studentModel, int Id)
        {
            //if (ModelState.IsValid)
            
                _istudentbusiness.Delete(studentModel, Id);

                return RedirectToAction("ShowData", "Student");
            
            //else
            //{
            //    return View(studentModel);
            //}

           
        }
        public IActionResult GetStudent()
        {

            return View(_istudentbusiness.GetStudent());
        }
    }
}
