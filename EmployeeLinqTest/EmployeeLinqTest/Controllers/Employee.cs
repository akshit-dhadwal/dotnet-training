using EmployeeLinqTest.Models;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace EmployeeLinqTest.Controllers
{
    public class Employee : Controller
    {
        

        List<EmployeeModel> model = new List<EmployeeModel>()
        {
            new EmployeeModel() { EmpId = 1, EmpName = "RAJAN", EmpAge = 25, EmpEmail = "rajan@gmail.com", EmpFathername = "Rajesh", EmpMothername = "Anjana", EmpSalary = 25000, EmpGender ="Male"},
            new EmployeeModel() { EmpId = 2, EmpName = "RAGHU", EmpAge = 23, EmpEmail = "raghu@gmail.com", EmpFathername = "Vijay", EmpMothername = "Kriya", EmpSalary = 28000, EmpGender ="Male" },
            new EmployeeModel(){EmpId = 3, EmpName = "MONIKA", EmpAge = 21, EmpEmail = "monika@gmail.com", EmpFathername = "Prakash", EmpMothername = "Sumitra", EmpSalary = 29000, EmpGender ="Female"},
            new EmployeeModel(){EmpId = 4, EmpName = "PRIYA", EmpAge = 22, EmpEmail = "priya@gmail.com", EmpFathername = "Surinder", EmpMothername = "Kamini", EmpSalary = 35000, EmpGender ="Female"},
            new EmployeeModel(){EmpId = 5, EmpName = "SOMESH", EmpAge = 28, EmpEmail = "somesh@gmail.com", EmpFathername = "Mohan", EmpMothername = "Divya", EmpSalary = 29000, EmpGender ="Male"},
            new EmployeeModel(){EmpId = 6, EmpName = "GOURAV", EmpAge = 23, EmpEmail = "gourav@gmail.com", EmpFathername = "Sohan", EmpMothername = "Bharti", EmpSalary = 20000, EmpGender ="Male"},
            new EmployeeModel(){EmpId = 7, EmpName = "ABHEY", EmpAge = 31, EmpEmail = "abhey@gmail.com", EmpFathername = "Ram", EmpMothername = "Kavya", EmpSalary = 53000, EmpGender ="Male"},
            new EmployeeModel(){EmpId = 8, EmpName = "SANIA", EmpAge = 30, EmpEmail = "sania@gmail.com", EmpFathername = "Shyam", EmpMothername = "Ginni", EmpSalary = 45000, EmpGender ="Female"},

        };
        List<EmployeeTechnology> technology = new List<EmployeeTechnology>()
        {
            new EmployeeTechnology(){EmpId = 1, EmpTechnology = "DOTNET"},
            new EmployeeTechnology(){EmpId = 2, EmpTechnology = "C#"},
            new EmployeeTechnology(){EmpId = 3, EmpTechnology = "DOTNET"},
            new EmployeeTechnology(){EmpId = 4, EmpTechnology = "PHP"},
            new EmployeeTechnology(){EmpId = 5, EmpTechnology = "ANGULAR"},
            new EmployeeTechnology(){EmpId = 6, EmpTechnology = "PHP"},
            new EmployeeTechnology(){EmpId = 7, EmpTechnology = "DOTNET"},
            new EmployeeTechnology(){EmpId = 8, EmpTechnology = "ANGULAR"},
        };



        public IActionResult Index()
        {
            return View();
        }

        public  IActionResult AllEmployee()
        {
            var Model = (from emp in model
                        select emp).ToList();


            return View(Model);
        }

        public  IActionResult EmployeeDetails(int id)
        {
            var Model = model.Where(x => x.EmpId == id).FirstOrDefault(); 
            return View(Model);
        }


        public IActionResult EmployeeSearch(string searchBy, string search, int? page )
        {
            if (searchBy == "EmpName")

                return View(model.Where(x => x.EmpName.StartsWith(search) || search == null).ToList());    /*|| search == null     this fetch allthe records from model*/


            else
                return View(model.Where(x => x.EmpGender == search || search == null).ToList());

        }

        public IActionResult EmployeeTechnology()
        {
            
            var Model = from emp in model
                        join emptech in technology on emp.EmpId equals emptech.EmpId into emptech2
                        from emptech in emptech2.DefaultIfEmpty()
                        select new JoinModel { employeeModel = emp, emptechnology = emptech };
           
            return View(Model) ;
        }


    }
}
