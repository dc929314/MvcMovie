using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMovie.Models
{
    public class Course
    {
        public int courseID { get; set; }
        [Display(Name = "Course Description")]
        [Required]
        public string CourseDescription { get; set; }

        public string description { get; set; }
        [Display (Name= "Credit Hours")]
        [Required]
        public string creditHours { get; set; }
        // add any other fields as appropriate
        //Product is on the "one" side of a one-to-many relationship with OrderDetail
        //we indicate that with an ICollection
        public ICollection<CourseDetail> CourseDetail { get; set; }

        //hey
    }
}