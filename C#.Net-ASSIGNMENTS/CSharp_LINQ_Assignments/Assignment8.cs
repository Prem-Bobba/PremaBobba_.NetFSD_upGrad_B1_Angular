using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_LINQ_Assignments
{
    internal class Assignment8
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
        {
            new Student { Id = 1, Name = "Ravi", Class = "10A", Subject = "Math", Marks = 80 },
            new Student { Id = 2, Name = "Kiran", Class = "10A", Subject = "Science", Marks = 70 },
            new Student { Id = 3, Name = "Amit", Class = "10A", Subject = "Math", Marks = 90 },
            new Student { Id = 4, Name = "Raj", Class = "10B", Subject = "Math", Marks = 60 },
            new Student { Id = 5, Name = "Anil", Class = "10B", Subject = "Science", Marks = 75 },
            new Student { Id = 6, Name = "Vijay", Class = "10B", Subject = "Math", Marks = 85 }
        };

            var groupedData = students
            .GroupBy(s => s.Class)
            .Select(cg => new
            {
                Class = cg.Key,
                Subjects = cg.GroupBy(s => s.Subject)
            });

            Console.WriteLine("Class → Subject:");
            foreach (var cg in groupedData)
            {
                Console.WriteLine(cg.Class);

                foreach (var sg in cg.Subjects)
                {
                    Console.WriteLine("  " + sg.Key);

                    foreach (var s in sg)
                    {
                        Console.WriteLine("    " + s.Name + " - " + s.Marks);
                    }
                }
            }

            var avgMarks = students
            .GroupBy(s => new { s.Class, s.Subject })
            .Select(g => new
            {
                g.Key.Class,
                g.Key.Subject,
                Avg = g.Average(x => x.Marks)
            });

            Console.WriteLine("\nAverage Marks:");
            foreach (var a in avgMarks)
            {
                Console.WriteLine($"{a.Class} - {a.Subject} - {a.Avg}");
            }
        }
    }
}
