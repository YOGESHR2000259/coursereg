using CourseRegMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseRegMVC.DAL
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Registration> Registrations { get; set; }
    }
}
