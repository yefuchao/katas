using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeReport.Infrastructure.Repositories.Tests
{
    [TestFixture()]
    public class SqliteEmployeeRepositoryTests : EmployeeRepositoryTests
    {
        public SqliteEmployeeRepositoryTests() : base(new DbContextOptionsBuilder<EmployeeDbContext>().UseSqlite("Filename=employee_test.db").Options)
        {

        }
    }
}
