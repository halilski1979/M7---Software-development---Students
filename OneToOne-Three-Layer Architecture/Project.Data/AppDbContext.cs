using Microsoft.EntityFrameworkCore;
using Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data
{
    public class AppDbContext:DbContext
    {
       public DbSet<Employee> Employees { get; set; } 
       public DbSet<IDCard> IDCards { get; set; }

        public AppDbContext() { }                                  
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (@"Server=DESKTOP-4BIU2L1\SQLEXPRESS;Database=OneToOne-3-LayerArchitecture;Trusted_Connection=True;TrustServerCertificate=True;");
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne(x => x.Card)
                .WithOne(x => x.Employee)
                .HasForeignKey<IDCard>(x => x.EmployeeId);
        }
    }
}
