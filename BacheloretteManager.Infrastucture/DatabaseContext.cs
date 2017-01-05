using BacheloretteManager.Core;
using Microsoft.EntityFrameworkCore;

namespace BacheloretteManager.Infrastucture
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().Property(student => student.FirstName).
                IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Student>().Property(student => student.LastName).
                IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Student>().Property(student => student.Password).
                IsRequired();
            modelBuilder.Entity<Student>().Property(student => student.Role).
                IsRequired();
            modelBuilder.Entity<Student>().Property(student => student.MeanA1).
                IsRequired();
            modelBuilder.Entity<Student>().Property(student => student.MeanA2).
                IsRequired();
            modelBuilder.Entity<Student>().Property(student => student.Preferences).
                IsRequired().HasMaxLength(100);

            modelBuilder.Entity<Teacher>().Property(teacher => teacher.FirstName).
                IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Teacher>().Property(teacher => teacher.LastName).
                IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Teacher>().Property(teacher => teacher.Password).
                IsRequired();
            modelBuilder.Entity<Teacher>().Property(teacher => teacher.Role).
                IsRequired();
            modelBuilder.Entity<Teacher>().Property(teacher => teacher.Requirements).
                IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Teacher>().Property(teacher => teacher.FreeSpaces).
                IsRequired();
            modelBuilder.Entity<Teacher>().Property(teacher => teacher.Available).
                IsRequired();

            modelBuilder.Entity<User>().Property(user => user.FirstName).
                IsRequired().HasMaxLength(100);
            modelBuilder.Entity<User>().Property(user => user.LastName).
                IsRequired().HasMaxLength(100);
            modelBuilder.Entity<User>().Property(user => user.Password).
                IsRequired();
            modelBuilder.Entity<User>().Property(user => user.Role).
                IsRequired().HasMaxLength(100);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BacheloretteManagerDB;Trusted_Connection=True;");
        }
    }
}
