using Microsoft.EntityFrameworkCore;
using Project.core;

namespace Project.Infrastructure
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EntityModel;Trusted_Connection=True;");
        }
    }
}
