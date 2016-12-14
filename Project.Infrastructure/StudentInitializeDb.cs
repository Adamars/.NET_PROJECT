using Microsoft.EntityFrameworkCore;
using Project.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Infrastructure
{
    public class StudentInitializeDb : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().Property(student => student.StudentFirstName).
                IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Student>().Property(student => student.StudentLastName).
               IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Student>().Property(student => student.MeanA1).
               IsRequired();
            modelBuilder.Entity<Student>().Property(student => student.MeanA2).
              IsRequired();
            modelBuilder.Entity<Student>().Property(student => student.Preferences).
              IsRequired().HasMaxLength(100);
        }
    }
}
