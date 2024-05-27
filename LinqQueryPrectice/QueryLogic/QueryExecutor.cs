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

            seprator();
            //Get Number of Employee join in perticular year.
            var employeeGroupByJoingYear = _dataProvidor.employees.GroupBy(x => x.JoiningYear);
            foreach(var employee in employeeGroupByJoingYear)
            {
                Console.WriteLine($"Employee Join in {employee.Key} : {employee.Count()}");
            }
            seprator();

            //seprator();
            ////Get Employee with its Department Name.
            //var employeeGroupByJoing = _dataProvidor.employees.GroupBy(x => x.JoiningYear);
            //foreach (var employee in employeeGroupByJoingYear)
            //{
            //    Console.WriteLine($"Employee Join in {employee.Key} : {employee.Count()}");
            //}
            //seprator();

            //Join Queries


            var customer = _dataProvidor.customers;
            var order = _dataProvidor.orders;

            //Inner Join: List all customers along with their orders. Display customer name, order ID, and order amount.
            seprator();
            var innerJoin = from c in customer
                            join o in order on c.CustomerId  equals o.CustomerId
                            select new { c.FirstName, c.LastName, o.OrderId, o.OrderAmount, o.OrderDate };
            foreach(var c in innerJoin)
            {
                Console.WriteLine($"{c.FirstName} {c.LastName} \t: \t{c.OrderId} \t{c.OrderAmount}  \t{c.OrderDate}");
            } 
            seprator();

            //  Join with Aggregate: Calculate the total order amount for each customer and display customer name and total order amount.
            seprator();
            var innerjoin1 = from o in order
                            group o by o.CustomerId into g
                            join c in customer on g.Key equals c.CustomerId
                            select new { c.FirstName, c.LastName, TotalAmount = g.Sum(x => x.OrderAmount) };
            foreach (var c in innerjoin1)
            {
                Console.WriteLine($"{c.FirstName} {c.LastName} \t: \t{c.TotalAmount}");
            }

            seprator();

            seprator();
            var innerjoin2 = from o in order
                             group o by o.CustomerId into g
                             join c in customer on g.Key equals c.CustomerId
                             select new { c.FirstName, c.LastName, Orders = g.Count() };
            foreach (var c in innerjoin2)
            {
                Console.WriteLine($"{c.FirstName} {c.LastName} \t: \t{c.Orders}");
            }
            seprator();
        }
        private void seprator()
        {
            Console.WriteLine("------------------------------------------------------------------------");
        }
    }
}
