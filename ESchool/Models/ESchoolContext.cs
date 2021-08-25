using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESchool.Models
{
    public class ESchoolContext:DbContext
    {
        public ESchoolContext(DbContextOptions<ESchoolContext> options): base(options)
        {

        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseTeacher> CourseTeachers  { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CourseTeacher>()
                .HasKey(ct => new { ct.TeacherId, ct.CourseId});
        }

    }
}
