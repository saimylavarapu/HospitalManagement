using Microsoft.EntityFrameworkCore;
using Models.Models;

namespace EFCore
{
    public class DatabaseContext : DbContext
    {
      
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {


        }
        public DbSet<user> Users { get; set; }
        public DbSet<Departnment> Departments { get; set; } 
        public DbSet<Doctor> Doctors { get; set; }
    }
}