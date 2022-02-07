using System.ComponentModel.DataAnnotations;

namespace user_validation_form.Models
{
    public class UserClass
    {
        [Key]
        public int UserId { get; set; }



      // [Range(1,99999,ErrorMessage ="please enter id between 1 to 99999")]
       // public int Id { get; set; }

       // [Required(ErrorMessage = "Please enter Username..")]
       // [Display(Name = "User Name")]
        public string Username { get; set; }

        //[Required(ErrorMessage = "Please enter Password..")]
        //[DataType(DataType.Password)]
        //[Display(Name = "Password")]
        public string Pwd { get; set; }

        //[Required(ErrorMessage = "Please enter Confirm Password..")]
        //[DataType(DataType.Password)]
        //[Display(Name = "Confirm Password")]
        //[Compare("Pwd")]
        public string Confirmpwd { get; set; }

        [Required(ErrorMessage = "Please enter Email..")]
        [Display(Name = "Email")]
        public string Uemail { get; set; }

        [Required(ErrorMessage = "Select Gender")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Select Marital Status")]
        [Display(Name = "Marital Status")]
        public string Maritalstatus { get; set; }

    }
}
