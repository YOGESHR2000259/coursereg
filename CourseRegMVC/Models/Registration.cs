using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CourseRegMVC.Models
{
    public class Registration
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Cannot Proceed without the FirstName.")]
        [MinLength(3, ErrorMessage = "First Name must be atleast 3 characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your LastName.")]
        [MinLength(3, ErrorMessage = "Last Name must be atleast 3 characters.")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string EmailId { get; set; }

        [Required]
        [DataType(DataType.Date, ErrorMessage = "Date is not Valid")]
        [Range(typeof(DateTime), "1998-05-20", "2100-12-31", ErrorMessage = "Date of Birth is not in a valid range (min/max age =25/35).")]
        public DateTime DOB { get; set; }



        [Required(ErrorMessage = "Please select a course.")]
        [ForeignKey("Course")]
        [DisplayName("Course Details")]
        public int CourseId { get; set; }
        public virtual Course Courses { get; set; }

    }
}
