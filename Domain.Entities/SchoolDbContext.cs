using Domain.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities
{
    public class SchoolDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public SchoolDbContext()
        {
            
        }

        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\mssqllocaldb;Database=SchoolDatabase1;Trusted_Connection=True;MultipleActiveResultSets=true");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<StudentCourse>()
                .HasKey(c => new
                {
                    c.CourseId, c.StudentId
                });

            modelBuilder.Entity<StudentCourse>()
                .HasOne<Student>()
                .WithMany(c => c.Courses)
                .HasForeignKey(c => c.StudentId);
                
            modelBuilder.Entity<StudentCourse>()
                .HasOne<Course>()
                .WithMany(c => c.Students)
                .HasForeignKey(c => c.CourseId);
                
        }
    }
}