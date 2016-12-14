using System;
//using System.Data.Entity;
using Project.core;
using Microsoft.EntityFrameworkCore;

namespace Project.Infrastructure
{
    public class TeacherInitializeDb : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Teacher>().Property(teacher => teacher.TeacherFirstName).
                IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Teacher>().Property(teacher => teacher.TeacherLastName).
               IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Teacher>().Property(teacher => teacher.TeacherLastName).
               IsRequired();
        }
    }
}
