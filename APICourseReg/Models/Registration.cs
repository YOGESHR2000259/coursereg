using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APICourseReg.Models
{
    public class Registration
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a name.")]
        [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters.")]

        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters.")]
        public string LastName { get; set; }

        [Required]
        [MaxLength(100)]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-Mail is not Valid")]
        public string EmailId { get; set; }

        [Required]
        [DataType(DataType.Date, ErrorMessage = "Date is not Valid")]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Please select a course.")]
        [ForeignKey("Course")]
        [DisplayName("Course Details")]
        public int CourseId { get; set; }
        public virtual Course Courses { get; set; }

    }
}
