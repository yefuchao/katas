using NUnit.Framework;
using EmployeeReport.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using EmployeeReport.Domain.Entities;
using System.Threading.Tasks;

namespace EmployeeReport.Infrastructure.Repositories.Tests
{
    [TestFixture()]
    public abstract class EmployeeRepositoryTests
    {
        public EmployeeRepositoryTests(DbContextOptions<EmployeeDbContext> contextOptions)
        {
            DbContextOptions = contextOptions;
            //Seed();
        }

        protected DbContextOptions<EmployeeDbContext> DbContextOptions { get; }

        [SetUp]
        public void SetUp()
        {
            using (var context = new EmployeeDbContext(DbContextOptions))
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var max = new Employee("Max", 17);
                var sepp = new Employee("Sepp", 18);
                var nina = new Employee("Nina", 15);
                var mike = new Employee("Mike", 51);

                context.AddRange(max, sepp, nina, mike);

                context.SaveChanges();
            }
        }

        [Test()]
        public async Task AgeOver18_Should_Return_2()
        {
            using (var context = new EmployeeDbContext(DbContextOptions))
            {

                var repository = new EmployeeRepository(context);

                var actual = await repository.AgeOver18Async();

                Assert.AreEqual(2, actual.Count);

            }
        }
    }
}