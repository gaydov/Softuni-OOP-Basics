using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyRoster
{
    public class Launcher
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Employee currentEmployee = new Employee(input[0], decimal.Parse(input[1]), input[2], input[3]);

                if (input.Length == 5)
                {
                    int age = 0;
                    bool isNumber = int.TryParse(input[4], out age);
                    if (isNumber)
                    {
                        currentEmployee.Age = age;
                    }
                    else
                    {
                        currentEmployee.Email = input[4];
                    }
                }

                else if (input.Length == 6)
                {
                    currentEmployee.Email = input[4];
                    currentEmployee.Age = int.Parse(input[5]);
                }

                employees.Add(currentEmployee);
            }

            var highestAvgSalaryDepartment = employees.GroupBy(e => e.Department)
                .Select(d => new
                {
                    Department = d.Key,
                    AvgSalary = d.Average(emp => emp.Salary),
                    Employees = d.OrderByDescending(emp => emp.Salary)
                })
                .OrderByDescending(d => d.AvgSalary)
                .FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {highestAvgSalaryDepartment.Department}");

            foreach (Employee employee in highestAvgSalaryDepartment.Employees)
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2} {employee.Email} {employee.Age}");
            }
        }
    }
}
