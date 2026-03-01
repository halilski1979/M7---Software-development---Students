using Microsoft.EntityFrameworkCore;
using Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data
{
    public class AppDbContext:DbContext
    {
        //Добавя се само за xUnitTest - BEGIN
        public AppDbContext() { }        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        //Добавя се само за xUnitTest - END


        // Таблиците в базата данни
        public DbSet<Employee> Employees { get; set; } 
        public DbSet<IDCard> IDCards { get; set; } 

        // Конфигуриране на връзката
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseLazyLoadingProxies() // Използваме Proxies за автоматично зареждане на свързани данни
                    .UseSqlServer(@"Server=DESKTOP-4BIU2L1\SQLEXPRESS;Database=OneToOne_EmployeeDB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        // Дефиниране на връзките между таблиците (Fluent API)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Конфигуриране на 1:1 връзка: Един служител има една карта
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Card)           // Employee има една Card
                .WithOne(c => c.Employee)      // Card има един Employee
                .HasForeignKey<IDCard>(c => c.EmployeeId); // Външният ключ е в таблицата IDCards
        }

    }
}
