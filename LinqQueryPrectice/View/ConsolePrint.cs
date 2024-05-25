﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqQueryPrectice.Models;

namespace LinqQueryPrectice.View
{
    public class ConsolePrint
    {
        public void DepartmentData(List<Department> departments)
        {
            Console.WriteLine("Departments:");
            if (departments != null || departments.Count.Equals(0))
            {
                Console.WriteLine("No Record of Departments Found");
            }
            foreach (var department in departments)
            {
                Console.WriteLine($"ID: {department.DepartmentId} \n" +
                    $"Name: {department.DepartmentName} \n");
            }
        }
        public void EmployeeData(List<Employee> employees)
        {
            Console.WriteLine("\nEmployees:");

            if(employees == null || employees.Count.Equals(0))
            {
                Console.WriteLine("No Record of Employees Found");
            }
            foreach (var employee in employees)
            {
                Console.WriteLine($"ID: {employee.EmployeeId} \n" +
                    $"Name: {employee.FirstName} {employee.LastName} \n" +
                    $"Position: {employee.Position} \n" +
                    $"Department ID: {employee.DepartmentId} \n" +
                    $"JoiningYear : {employee.JoiningYear} \n" + 
                    $"Salary : {employee.Salary}\n");
            }
        }
    }
}
