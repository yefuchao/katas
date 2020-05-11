using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeReport.Domain.Entities
{
    public class Employee
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public Employee() { }

        public Employee(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
