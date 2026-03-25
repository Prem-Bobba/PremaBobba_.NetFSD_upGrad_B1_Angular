using System;
using System.Collections.Generic;
using System.Text;

namespace C__Collections_Assignments
{
    internal class Assignment2
    {
        static void Main()
        {
            Dictionary<int, Student> students = new Dictionary<int, Student>();

            students.Add(1, new Student { Id = 1, Name = "Ravi", Marks = 80 });
            students.Add(2, new Student { Id = 2, Name = "Kiran", Marks = 65 });
            students.Add(3, new Student { Id = 3, Name = "Amit", Marks = 90 });
            students.Add(4, new Student { Id = 4, Name = "Raj", Marks = 70 });
            students.Add(5, new Student { Id = 5, Name = "Anil", Marks = 85 });
            
            int searchId = 3;
            if (students.ContainsKey(searchId))
            {
                var s = students[searchId];
                Console.WriteLine($"Found: {s.Name} - {s.Marks}");
            }
          
            if (students.ContainsKey(2))
            {
                Console.WriteLine("Student with ID 2 exists");
            }
            
            if (students.ContainsKey(2))
            {
                students[2].Marks = 75;
            }

            students.Remove(4);
          
            Console.WriteLine("\nAll Students:");
            foreach (var s in students.Values)
            {
                Console.WriteLine($"{s.Id} - {s.Name} - {s.Marks}");
            }
        
            Console.WriteLine("\nStudents with Marks > 75:");
            foreach (var s in students.Values)
            {
                if (s.Marks > 75)
                {
                    Console.WriteLine($"{s.Name} - {s.Marks}");
                }
            }

        }
    }
}
