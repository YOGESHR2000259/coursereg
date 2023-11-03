using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CourseRegMVC.Models
{
    public class Course
    {
        [Key]
        
        public int Id { get; set; }
        [DisplayName("Course")]
        
        [Required(ErrorMessage = "Please enter a Course name.")]
        [MinLength(4, ErrorMessage = "Shortcut names are not allowed.")]
        
        public string Name { get; set; }

        public string CourseStartDate { get; set; }

        public string CourseEndDate { get; set; }

        public string Duration { get; set; }   

        public string Fees { get; set; }


    }
}
