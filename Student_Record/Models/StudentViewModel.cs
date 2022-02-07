using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Student_Record.Models
{
    public class StudentViewModel
    {
       
    }
    public class Student
    {
        [Display(Name = "RollNumber")]
        public int Roll { get; set; }
        [Display(Name = "Name")]
        public string? Name { get; set; }
        [Display(Name = "Age")]
        public int Age { get; set; }
      
    }
}
