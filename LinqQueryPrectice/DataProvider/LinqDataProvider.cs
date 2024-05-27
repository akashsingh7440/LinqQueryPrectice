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

        public List<Customer> customers = new List<Customer>
        {
            new Customer { CustomerId = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", Phone = "123-456-7890" },
            new Customer { CustomerId = 2, FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com", Phone = "234-567-8901" },
            new Customer { CustomerId = 3, FirstName = "Michael", LastName = "Brown", Email = "michael.brown@example.com", Phone = "345-678-9012" },
            new Customer { CustomerId = 4, FirstName = "Emily", LastName = "Davis", Email = "emily.davis@example.com", Phone = "456-789-0123" }
        };

        public List<Order> orders = new List<Order>
        {
            new Order { OrderId = 101, CustomerId = 1, OrderDate = new DateTime(2023, 1, 15), OrderAmount = 250.75m },
            new Order { OrderId = 102, CustomerId = 2, OrderDate = new DateTime(2023, 2, 20), OrderAmount = 100.50m },
            new Order { OrderId = 103, CustomerId = 1, OrderDate = new DateTime(2023, 3, 5), OrderAmount = 300.00m },
            new Order { OrderId = 104, CustomerId = 3, OrderDate = new DateTime(2023, 4, 12), OrderAmount = 150.25m },
            new Order { OrderId = 105, CustomerId = 4, OrderDate = new DateTime(2023, 5, 19), OrderAmount = 75.00m },
            new Order { OrderId = 106, CustomerId = 2, OrderDate = new DateTime(2023, 6, 25), OrderAmount = 200.60m },
            new Order { OrderId = 107, CustomerId = 3, OrderDate = new DateTime(2023, 7, 30), OrderAmount = 180.80m },
            new Order { OrderId = 108, CustomerId = 4, OrderDate = new DateTime(2023, 8, 10), OrderAmount = 220.90m }
        };

    }
}
