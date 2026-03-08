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
        public DbSet<Model> Models { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseLazyLoadingProxies()
                    // Добавихме TrustServerCertificate=True, за да разрешим връзката
                    .UseSqlServer(@"Server=DESKTOP-4BIU2L1\SQLEXPRESS;Database=OneToMany-Three-Layer Architecture;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Дефиниране на 1:N връзка
            modelBuilder.Entity<Manufacturer>()
                .HasMany(m => m.Models)
                .WithOne(mo => mo.Manufacturer)
                .HasForeignKey(mo => mo.ManufacturerId)
                .OnDelete(DeleteBehavior.Cascade); // При изтриване на производител, трие и моделите му
        }
    }
}
