using Microsoft.EntityFrameworkCore;
using ReadApi.Models;
namespace ReadApi.Data

{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Course> Course { get; set; }
        public DbSet<CourseCatagory> CourseCategory { get; set; }
        public DbSet<CourseLevel> CourseLevels { get; set; }
        public DbSet<UserProgress> UserProgress { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Topic> Topic { get; set; }
        
    }
}
