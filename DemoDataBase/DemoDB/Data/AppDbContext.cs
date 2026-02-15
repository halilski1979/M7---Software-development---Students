using DemoDB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDB.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
            @"Server=DESKTOP-4BIU2L1\SQLEXPRESS; Database=PersonsDB; Trusted_Connection=True; TrustServerCertificate=True"
                );
        }
    }
}
