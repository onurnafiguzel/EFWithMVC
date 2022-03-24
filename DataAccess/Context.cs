using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Context : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Lesson> Lessons { get; set; }

        public DbSet<StudentLesson> StudentLessons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB; Database=University; Integrated Security=yes");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().Property(x => x.FirstName)
                                          .IsRequired();
            modelBuilder.Entity<Student>().Property(x => x.LastName)
                                          .IsRequired();
            modelBuilder.Entity<Student>().Property(x => x.SchoolId)
                                          .IsRequired();

            modelBuilder.Entity<Lesson>().Property(x => x.Name)
                                         .IsRequired();

            modelBuilder.Entity<Classroom>().Property(x => x.Name)
                                            .IsRequired();

            modelBuilder.Entity<Teacher>().Property(t => t.FirstName)
                                          .IsRequired();
            modelBuilder.Entity<Teacher>().Property(t => t.LastName)
                                          .IsRequired();

            //Lesson(1) - Teacher(M)
            modelBuilder.Entity<Lesson>().HasOne(lesson => lesson.Teacher)
                                         .WithMany(teacher => teacher.Lessons)
                                         .HasForeignKey(f => f.TeacherId)
                                         .OnDelete(DeleteBehavior.SetNull);


            //Lesson(1) - Classroom(M)
            modelBuilder.Entity<Lesson>().HasOne(lesson => lesson.Classroom)
                                         .WithMany(classroom => classroom.Lessons)
                                         .HasForeignKey(f => f.ClassroomId)
                                         .OnDelete(DeleteBehavior.SetNull);



            modelBuilder.Entity<StudentLesson>().HasKey("StudentId", "LessonId");

            //Lesson(M) - Student(M)
            modelBuilder.Entity<Lesson>().HasMany(s => s.Students)
                                         .WithOne(sl => sl.Lesson)
                                         .HasForeignKey(x => x.LessonId)
                                         .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Student>().HasMany(l => l.Lessons)
                                          .WithOne(sl => sl.Student)
                                          .HasForeignKey(x => x.StudentId)
                                          .OnDelete(DeleteBehavior.NoAction);

            //First Datas
            modelBuilder.Entity<Teacher>().HasData(new Teacher { Id = 1, FirstName = "Uğur", LastName = "Gürel" });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 1, FirstName = "Onur", LastName = "Güzel", SchoolId = "1" });
            modelBuilder.Entity<Classroom>().HasData(new Classroom { Id = 1, Name = "B-245" });
            modelBuilder.Entity<StudentLesson>().HasData(new StudentLesson { Id = 1, LessonId = 1, StudentId = 1 });
            modelBuilder.Entity<Lesson>().HasData(new Lesson { Id = 1, Name = "Bitirme Projesi", ClassroomId = 1, TeacherId = 1 });
        }
    }
}
