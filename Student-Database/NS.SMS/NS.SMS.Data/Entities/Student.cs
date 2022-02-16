using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace NS.SMS.WEB.Entities
{
    public  class Student
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Age is required")]
        public int? Age { get; set; }

        [Required(ErrorMessage = "Class is required")]
        [Display(Name = "Class")]
        public string Division { get; set; }

        [Required(ErrorMessage = "Father Name is required")]
        [Display(Name = "Father Name ")]
        public string FatherName { get; set; }

        [Required(ErrorMessage = "Mother Name is required")]
        [Display(Name = "Mother Name")]
        public string MotherName { get; set; }


        [Required(ErrorMessage = "Please enter your email address")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email address")]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public string Email { get; set; }

       //public string CoverImageUrl { get; set; }


        [Required]
        public Department DeptId { get; set; }

        public enum Department
        {
            IT = 1,
            CSE = 2,
            MECH = 3

        }

    }
 
}
