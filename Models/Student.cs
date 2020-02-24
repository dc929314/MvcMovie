using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace MvcMovie.Models
{
    public class Student
    {
        public System.Guid SID { get; set; }
        
        public int studentID { get; set; }
        [Display (Name="First Name")] 
        [Required(ErrorMessage = "Student First Name is Required")]
        [StringLength(20)]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Student Last Name is Required")]
        [StringLength(20)]
        public string lastName { get; set; }
        [Display(Name = "Most used Email address")]
        [Required]
        [EmailAddress(ErrorMessage = "Enter you most used Email Address")]
        public string email { get; set; }
        [Display(Name = "Mobile Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) | \d{3}-)\d{3}-\d{4}$",
            ErrorMessage ="Phone number must be in the format: (xxx)-xxx-xxxx")]

        public string phone { get; set; }
        [Display(Name = "Street")]
        [StringLength(100)]
        [Required]
        public string LocalStreet { get; set; }
        [Display(Name = "City")]
        [StringLength(50)]
        [Required]
        public string LocalCity { get; set; }
        [Display(Name = "State")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "State must be two characters")]
        [Required]
        public string LocalState { get; set; }
        [Display(Name = "When did you join the University?")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime studentSince { get; set; }

        public ICollection<CourseDetail> CourseDetail { get; set; }

    }
    
}
