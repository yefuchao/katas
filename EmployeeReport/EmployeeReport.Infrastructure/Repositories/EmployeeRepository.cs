using EmployeeReport.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeReport.Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext _context;

        public EmployeeRepository(EmployeeDbContext context)
        {
            _context = context;
        }

        public Employee Add(string name, int age)
        {
            return _context.Employees.Add(new Employee(name, age)).Entity;
        }

        public async Task<ICollection<Employee>> AgeOver18Async()
        {
            return await _context.Employees.Where(p => p.Age >= 18).ToListAsync();
        }

        public async Task<ICollection<Employee>> All()
        {
            return await _context.Employees.ToListAsync();
        }

        public Employee Get(string name)
        {
            return _context.Employees.Where(p => p.Name == name).FirstOrDefault();
        }
    }
}
