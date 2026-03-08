using CarSystem.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSystem.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Model>Models { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (@"Server=DESKTOP-4BIU2L1\SQLEXPRESS;Database=OneToMany-Three-Layer-Students;Trusted_Connection=True;TrustServerCertificate=True;");
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manufacturer>()
                .HasMany(x=>x.Models)
                .WithOne(x => x.Manufacturer)
                .HasForeignKey(x => x.ManufacturerId)
                .OnDelete(DeleteBehavior.Cascade);
        }


    }
}
