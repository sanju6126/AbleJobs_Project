using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AbleProject_Empty.Models
{
    public class ResumeModel
    {
        public int StudentId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Student Name is Required")]
        [Display(Name = "Student Name: ")]
        public String StudentName { get; set; }


        //[Required(AllowEmptyStrings = false, ErrorMessage = "Gender is Required")]
        //[Display(Name = "Gender: ")]
        //public Gender Gender { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Email is Required")]
        [Display(Name = "Email: ")]
        public String Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Contact is Required")]
        [Display(Name = "Contact No.: ")]
        public String Contact { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "School Name is Required")]
        [Display(Name = "School Name: ")]
        public String School { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Percentage is Required")]
        [Display(Name = "12th Percentage: ")]
        public String PlusTwoPercentage { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "College Name is Required")]
        [Display(Name = "Graduation College Name: ")]
        public String College { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Branch is Required")]
        [Display(Name = "Branch of Study: ")]
        public String Branch { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Percentage is Required")]
        [Display(Name = "Graduation Percentage: ")]
        public String GraduationPercentage { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "No. is Required")]
        [Display(Name = "Active Backlogs(In Numbers): ")]
        public String Backlogs { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Description is Required")]
        [Display(Name = "Description: ")]
        public String Description { get; set; }

        [Display(Name = "Posted On: ")]
        public DateTime PostedOn { get; set; }

    }


    public enum Gender
    {
        Male,
        Female,
        Others
    }
}