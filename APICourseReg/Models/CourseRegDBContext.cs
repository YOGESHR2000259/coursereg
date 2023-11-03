using APICourseReg.Models;
using Microsoft.EntityFrameworkCore;
namespace APICourseReg.Models
{
    public class CourseRegDBContext : DbContext
    {
        public CourseRegDBContext(DbContextOptions<CourseRegDBContext> options) : base(options)
        {
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Registration> Registration { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-5KSBNBE;Initial Catalog=APICourseReg;Integrated Security=True;TrustServerCertificate=yes;");
        }
    }
}
