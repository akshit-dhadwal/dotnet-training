using System.ComponentModel.DataAnnotations;
using PagedList.Mvc;
using PagedList;

namespace EmployeeLinqTest.Models
{
    public class EmployeeModel
    {
        [Required(ErrorMessage ="Please enter the Employee Id")]
        public int EmpId { get; set; } 

        public string EmpName { get; set; }

        public int EmpAge { get; set; }

        public string EmpGender { get; set; }

        public string EmpEmail { get; set; }

        public string EmpFathername { get; set; }

        public string EmpMothername { get; set; }

        public int EmpSalary { get; set; }

    }
    public class EmployeeTechnology
    {
        public int EmpId { get; set; }

        public string EmpTechnology { get; set; }
    }

    public class JoinModel
    {
        public EmployeeModel employeeModel { get; set; }
        public EmployeeTechnology emptechnology { get; set; }
    }

}
