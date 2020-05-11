using EmployeeReport.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeReport.Infrastructure
{
    public class EmployeeDbContext : DbContext
    {
        public virtual DbSet<Employee> Employees { get; set; }


        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(
                e =>
                {
                    e.HasKey("Id");
                    e.Property("Id");
                    e.Property("Name");
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
