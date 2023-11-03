using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace APICourseReg.Models
{
    public class Course
    {
        [Key]

        public int Id { get; set; }
        [DisplayName("Course")]

        [Required(ErrorMessage = "Please enter a Course name.")]

        public string Name { get; set; }
    }
}
