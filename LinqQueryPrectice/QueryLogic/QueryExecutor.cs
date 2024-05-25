using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqQueryPrectice.DataProvider;
using LinqQueryPrectice.Models;
using LinqQueryPrectice.View;

namespace LinqQueryPrectice.QueryLogic
{
    public class QueryExecutor
    {
        public readonly ConsolePrint _consolePrint;
        private readonly LinqDataProvider _dataProvidor;
        public QueryExecutor(LinqDataProvider dataProvidor, ConsolePrint linqPrectice)
        {
            _consolePrint = linqPrectice;
            _dataProvidor = dataProvidor;
        }
        public void CreateAndRunQuery()
        {
            
            seprator();
            //Get all the employee whose name start with J.
            var employees = _dataProvidor.employees.FindAll(x => x.FirstName.StartsWith("J"));
            _consolePrint.EmployeeData(employees);
            seprator();

            //Find Total number of employee in every department.


            seprator();
            //Get list of employee who joind after 2010.
            employees = _dataProvidor.employees.FindAll(x => x.JoiningYear == 2011);
            _consolePrint.EmployeeData(employees);
            seprator();

            seprator();
            //Get list of Employee with Highest Salary.
            int highestSalary = _dataProvidor.employees.Max(x => x.Salary);
            employees = _dataProvidor.employees.FindAll(x => x.Salary == highestSalary);
            _consolePrint.EmployeeData(employees);
            seprator();

            seprator();
            //Get Top 3 Employees with Highest Salary.
            var highestPaidEmployees = _dataProvidor.employees.OrderByDescending(x => x.Salary).Take(3).ToList();
            _consolePrint.EmployeeData(highestPaidEmployees);
            seprator();

        }
        private void seprator()
        {
            Console.WriteLine("------------------------------------------------------------------------");
        }
    }
}
