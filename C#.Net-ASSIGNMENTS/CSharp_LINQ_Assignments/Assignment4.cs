using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_LINQ_Assignments
{
    internal class Assignment4
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

            var itEmployees = employees.Where(e => e.Department == "IT");
            Console.WriteLine("IT Employees:");
            foreach (var e in itEmployees)
                Console.WriteLine(e.Name);

            var highest = employees.OrderByDescending(e => e.Salary).First();
            Console.WriteLine($"\nHighest Salary: {highest.Name} - {highest.Salary}");

            var avgSalary = employees.Average(e => e.Salary);
            Console.WriteLine($"\nAverage Salary: {avgSalary}");

            var groups = employees.GroupBy(e => e.Department);
            Console.WriteLine("\nGrouped by Department:");
            foreach (var group in groups)
            {
                Console.WriteLine(group.Key);
                foreach (var e in group)
                    Console.WriteLine("  " + e.Name);
            }

            Console.WriteLine("\nEmployee Count per Department:");
            foreach (var group in groups)
            {
                Console.WriteLine($"{group.Key} - {group.Count()}");
            }
        }
    }
}
