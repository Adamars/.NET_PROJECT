using Microsoft.EntityFrameworkCore;
using Project.core;
//using System.Data.Entity;


namespace Project.Infrastructure
{
    public class TeacherContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EntityModel;Trusted_Connection=True;");
        }
    }
}
