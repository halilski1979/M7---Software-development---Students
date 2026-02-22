using Microsoft.EntityFrameworkCore;
using OneToManyDB.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyDB.Data
{
    public class AppDbContext:DbContext
    {
        public const string ConectionString =
            "Server=DESKTOP-4BIU2L1\\SQLEXPRESS; Database=OneToMany2026godina; Trusted_Connection=True; TrustServerCertificate=True";

        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Model>Models { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConectionString);
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Да няма повтарящи се производители
            modelBuilder.Entity<Manufacturer>().
                HasIndex(x=>x.Name).
                IsUnique();
        }
    }
}
