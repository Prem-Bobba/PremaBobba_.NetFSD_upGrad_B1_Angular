using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_LINQ_Assignments
{
    internal class Assignment6
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 2, 4, 5, 3, 6 };

            var uniqueNumbers = numbers.Distinct();
            Console.WriteLine("Unique Numbers:");
            foreach (var n in uniqueNumbers)
                Console.WriteLine(n);

            var duplicates = numbers
            .GroupBy(n => n)
            .Where(g => g.Count() > 1)
            .Select(g => g.Key);

            Console.WriteLine("\nDuplicate Values:");
            foreach (var n in duplicates)
                Console.WriteLine(n);

            var counts = numbers
            .GroupBy(n => n)
            .Select(g => new
            {
                Number = g.Key,
                Count = g.Count()
            });

            Console.WriteLine("\nOccurrences:");
            foreach (var item in counts)
                Console.WriteLine($"{item.Number} - {item.Count}");

        }
    }
}
