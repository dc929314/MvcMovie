using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMovie.Models
{
    public class CourseDetail
    {
        public int courseDetailID { get; set; }
        public string courseName { get; set; }
        public string grade { get; set; }
        // the next two properties link the orderDetail to the Order
        public int courseID { get; set; }
        public virtual Course Course { get; set; }
        // the next two properties link the orderDetail to the Product
        public int studentID { get; set; }
        public virtual Student Student { get; set; }
    }
}