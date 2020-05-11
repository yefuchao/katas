using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeReport.Domain.Entities
{
    public interface IEmployeeRepository
    {
        Task<ICollection<Employee>> AgeOver18Async();

        Employee Get(string name);

        Task<ICollection<Employee>> All();

        Employee Add(string name, int age);

    }
}
