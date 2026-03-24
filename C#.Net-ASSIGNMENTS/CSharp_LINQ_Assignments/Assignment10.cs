using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_LINQ_Assignments
{
    internal class Assignment10
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1, Name = "Ravi", Department = "IT", Salary = 50000 },
                new Employee { Id = 2, Name = "Kiran", Department = "HR", Salary = 40000 },
                new Employee { Id = 3, Name = "Amit", Department = "IT", Salary = 70000 },
                new Employee { Id = 4, Name = "Raj", Department = "Finance", Salary = 60000 },
                new Employee { Id = 5, Name = "Anil", Department = "HR", Salary = 45000 }
            };

            var sortedEmployees = employees
               .OrderBy(e => e.Department)          
               .ThenByDescending(e => e.Salary);    

            Console.WriteLine("Sorted Employees:");

            foreach (var e in sortedEmployees)
            {
                Console.WriteLine($"{e.Department} - {e.Name} - {e.Salary}");
            }

        }
    }
}
