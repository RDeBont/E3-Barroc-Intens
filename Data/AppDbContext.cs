using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E3_Barroc_Intens.Models;
using Microsoft.EntityFrameworkCore;

namespace E3_Barroc_Intens.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;port=3306;database=barroc_intens;user=root;password=;",
                new MySqlServerVersion(new Version(8, 0, 30)));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "Management" },
                new Department { Id = 2, Name = "Finance" },
                new Department { Id = 3, Name = "Sales" },
                new Department { Id = 4, Name = "Purchasing" },
                new Department { Id = 5, Name = "Maintenance" });
        }
    }
}
