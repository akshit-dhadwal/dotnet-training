using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NS.SMS.Model
{
    public class StudentDeptModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Division { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public string FatherName { get; set; }
        public string MotherName { get; set; }

        public int DeptId { get; set; }

        public string DeptName { get; set; }
    }
}
