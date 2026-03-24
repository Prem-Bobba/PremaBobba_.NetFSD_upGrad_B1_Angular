using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_LINQ_Assignments
{
    internal class Assignment11
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>()
        {
            new Employee { Id = 1, Name = "Ravi", Department = "IT", Salary = 50000, JoiningDate = DateTime.Now.AddMonths(-2) },
            new Employee { Id = 2, Name = "Kiran", Department = "HR", Salary = 40000, JoiningDate = DateTime.Now.AddMonths(-8) },
            new Employee { Id = 3, Name = "Amit", Department = "IT", Salary = 70000, JoiningDate = DateTime.Now.AddMonths(-1) },
            new Employee { Id = 4, Name = "Raj", Department = "Finance", Salary = 60000, JoiningDate = DateTime.Now.AddMonths(-12) },
            new Employee { Id = 5, Name = "Anil", Department = "HR", Salary = 45000, JoiningDate = DateTime.Now.AddMonths(-3) }
        };

            Console.WriteLine("DASHBOARD");

            Console.WriteLine("Total Employees: " + employees.Count());

            var avgSalary = employees.GroupBy(e => e.Department)
            .Select(g => new { g.Key, Avg = g.Average(x => x.Salary) });

            Console.WriteLine("\nAvg Salary:");
            foreach (var a in avgSalary)
                Console.WriteLine($"{a.Key} - {a.Avg}");

            var recent = employees.Where(e => e.JoiningDate >= DateTime.Now.AddMonths(-6));

            Console.WriteLine("\nRecent Employees:");
            foreach (var e in recent)
                Console.WriteLine(e.Name);

            var highest = employees.GroupBy(e => e.Department)
           .Select(g => new { g.Key, Emp = g.OrderByDescending(x => x.Salary).First() });

            Console.WriteLine("\nHighest Paid:");
            foreach (var h in highest)
                Console.WriteLine($"{h.Key} - {h.Emp.Name}");

            Console.WriteLine("\nSalary Distribution:");
            Console.WriteLine("Min: " + employees.Min(e => e.Salary));
            Console.WriteLine("Max: " + employees.Max(e => e.Salary));
            Console.WriteLine("Avg: " + employees.Average(e => e.Salary));
        }
    }
}
