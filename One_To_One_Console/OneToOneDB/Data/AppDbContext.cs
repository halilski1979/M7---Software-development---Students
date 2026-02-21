using Microsoft.EntityFrameworkCore;
using OneToOneDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOneDB.Data
{
    public class AppDbContext:DbContext
    {
        
        //Таблиците в БД
        public DbSet<Person> Persons { get; set; }
        public DbSet<Passport> Passports { get; set; }

        //Връзка към базата данни
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (@"Server=DESKTOP-4BIU2L1\SQLEXPRESS; Database=OneToOne2026; Trusted_Connection=True; TrustServerCertificate=True");
            optionsBuilder.UseLazyLoadingProxies();
        }
               
        //Връзка 1:1
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().
                HasOne(p => p.Passport).  //Person има 1 Passport
                WithOne(p => p.Person).   //Passport има 1 Person
                HasForeignKey<Passport>(p => p.PersonId);

            //Не може да се повтаря  номера на паспорта
            modelBuilder.Entity<Passport>()
                .HasIndex(p => p.PassportNumber)
                .IsUnique();

            // Не може да се повтаря  номера на PerosnID
            modelBuilder.Entity<Passport>()
                .HasIndex(p=>p.PersonId)
                .IsUnique();
        }




    }
}
