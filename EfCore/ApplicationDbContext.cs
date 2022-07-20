using EfCore.Configration;
using EfCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore
{
    class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlServer("Data Source=DESKTOP-9864HC3;Initial Catalog=EfCore;Integrated Security=True");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new EmpolyeeTypeCongration().Configure(modelBuilder.Entity<Employee>());
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
