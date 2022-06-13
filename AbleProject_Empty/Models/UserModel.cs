using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AbleProject_Empty.Models
{
    public class UserModel
    {
        public int UserId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Company Name is Required")]
        [Display(Name = "Company Name: ")]
        public String CompanyName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "First Name is Required")]
        [Display(Name = "Employee First Name: ")]
        public String FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Last Name is Required")]
        [Display(Name = "Employee Last Name: ")]
        public String LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Email is Required")]
        [Display(Name = "Email: ")]
        public String Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is Required")]
        [DataType(DataType.Password)]
        [Display(Name = "Password: ")]
        public String Password { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Confirm Password is Required")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and Confirm Password Should be Same")]
        [Display(Name = "Confirm Password: ")]
        public String ConfirmPassword { get; set; }

        [Display(Name = "Created On: ")]
        public DateTime CreatedOn { get; set; }

        public string SuccessMessage { get; set; }

    }
}