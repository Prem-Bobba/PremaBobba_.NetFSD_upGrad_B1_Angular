using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_LINQ_Assignments
{
    internal class Assignment3
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>
        {
            "Ravi", "Kiran", "Amit", "Raj", "Anil"
        };
            var aNames = names.Where(n => n.StartsWith("A"));
            Console.WriteLine("Names starting with A:");
            foreach (var name in aNames)
                Console.WriteLine(name);

            var sortedNames = names.OrderBy(n => n);
            Console.WriteLine("\nSorted Names:");
            foreach (var name in sortedNames)
                Console.WriteLine(name);

            var upperNames = names.Select(n => n.ToUpper());
            Console.WriteLine("\nUppercase Names:");
            foreach (var name in upperNames)
                Console.WriteLine(name);

            var longNames = names.Where(n => n.Length > 4);
            Console.WriteLine("\nNames with length > 4:");
            foreach (var name in longNames)
                Console.WriteLine(name);

        }
    }
}
