using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqQueryPrectice.Models;

namespace LinqQueryPrectice.DataProvider
{
    public class LinqDataProvider
    {
        public List<Department> departments = new List<Department>
        {
            new Department { DepartmentId = 1, DepartmentName = "Human Resources" },
            new Department { DepartmentId = 2, DepartmentName = "Finance" },
            new Department { DepartmentId = 3, DepartmentName = "Engineering" },
            new Department { DepartmentId = 4, DepartmentName = "Marketing" }
        };

        public List<Employee> employees = new List<Employee>
        {
            new Employee { EmployeeId = 101, FirstName = "John", LastName = "Doe", Position = "HR Manager", DepartmentId = 1, JoiningYear = 2015, Salary = 100000 },
            new Employee { EmployeeId = 102, FirstName = "Jane", LastName = "Smith", Position = "Accountant", DepartmentId = 2, JoiningYear = 2010, Salary = 120000 },
            new Employee { EmployeeId = 103, FirstName = "Michael", LastName = "Brown", Position = "Software Engineer", DepartmentId = 3, JoiningYear = 2013, Salary = 140000 },
            new Employee { EmployeeId = 104, FirstName = "Emily", LastName = "Davis", Position = "Marketing Specialist", DepartmentId = 4, JoiningYear = 2010, Salary = 110000 },
            new Employee { EmployeeId = 105, FirstName = "Daniel", LastName = "Wilson", Position = "HR Coordinator", DepartmentId = 1, JoiningYear = 2021, Salary = 120000 },
            new Employee { EmployeeId = 106, FirstName = "Sarah", LastName = "Miller", Position = "Finance Analyst", DepartmentId = 2, JoiningYear = 2022, Salary = 170000 },
            new Employee { EmployeeId = 107, FirstName = "David", LastName = "Lee", Position = "DevOps Engineer", DepartmentId = 3, JoiningYear = 2014, Salary = 130000 },
            new Employee { EmployeeId = 108, FirstName = "Laura", LastName = "Taylor", Position = "Marketing Manager", DepartmentId = 4, JoiningYear = 2015, Salary = 200000 }
        };

    }
}
