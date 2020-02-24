using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMovie.Models
{
    public class CourseDetail
    {
        [Display(Name = "Course Detail ID")]
        [Required(ErrorMessage = "Course Detail ID is required")]
        public int courseDetailID { get; set; }
        [Display(Name = "Course Name")]
        [Required(ErrorMessage = "Course Name is Required")]
        public string courseName { get; set; }
        [Display(Name = "Grade")]
        [Required(ErrorMessage = "Grade is Required")]
        public string grade { get; set; }
        // the next two properties link the orderDetail to the Order
        [Display(Name = "Course ID")]
        [Required(ErrorMessage = "Course ID is Required")]
        public string courseID { get; set; }
        public virtual Course Course { get; set; }
        // the next two properties link the orderDetail to the Product
        [Display(Name = "Student ID")]
        [Required(ErrorMessage = "Student ID is Required")]
        public int studentID { get; set; }
        public virtual Student Student { get; set; }


    }
}