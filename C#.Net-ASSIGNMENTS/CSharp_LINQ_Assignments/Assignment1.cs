using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_LINQ_Assignments
{
    internal class Assignment1
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
        {
            new Student { Id = 1, Name = "A", Age = 20, Marks = 80 },
            new Student { Id = 2, Name = "B", Age = 17, Marks = 60 },
            new Student { Id = 3, Name = "C", Age = 22, Marks = 90 },
            new Student { Id = 4, Name = "D", Age = 19, Marks = 70 },
            new Student { Id = 5, Name = "E", Age = 24, Marks = 85 }
        };

            Console.WriteLine("Marks > 75:");
            var highMarks = students.Where(s => s.Marks > 75);
            foreach (var s in highMarks)
                Console.WriteLine($"{s.Name} - {s.Marks}");

            Console.WriteLine();

            Console.WriteLine("\nAge between 18 and 25");
            var ageFilter = students.Where(s => s.Age >= 18 && s.Age <= 25);
            foreach (var s in ageFilter)
                Console.WriteLine($"{s.Name} - {s.Age}");

            Console.WriteLine();

            Console.WriteLine("\nSorted by Marks Desc");
            var Sorted = students.OrderByDescending(s => s.Marks);
            foreach (var s in Sorted)
                Console.WriteLine($"{s.Name} - {s.Marks}");

            Console.WriteLine();

            Console.WriteLine("\nSelect Name & Marks");
            var selectData = students.Select(s => new { s.Name, s.Marks });
            foreach (var s in selectData)
                Console.WriteLine($"{s.Name} - {s.Marks}");
        }
    }

}
