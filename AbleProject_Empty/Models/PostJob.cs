using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AbleProject_Empty.Models
{
    public class PostJob
    {
        public int JobId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Company Name is Required")]
        [Display(Name = "Job Role: ")]
        public String JobRole { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Desciption is Required")]
        [Display(Name = "Job Description: ")]
        public String JobDescription { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Address is Required")]
        [Display(Name = "Place Of Work: ")]
        public String Address { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Contact Number is Required")]
        [Display(Name = "Phone No. For Coordination: ")]
        public int Phone { get; set; }
  

        [Display(Name = "Created On: ")]
        public DateTime CreatedOn { get; set; }

        //public string SuccessMessage { get; set; }

    }
}