using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_LINQ_Assignments
{
    internal class Assignment2
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 5, 10, 15, 20, 25, 30 };

            var evenNumbers = numbers.Where(n => n % 2 == 0);
            Console.WriteLine("Even Numbers:");
            foreach (var n in evenNumbers)
                Console.WriteLine(n);

            var greaterThan15 = numbers.Where(n => n > 15);
            Console.WriteLine("\nNumbers > 15:");
            foreach (var n in greaterThan15)
                Console.WriteLine(n);

            var squares = numbers.Select(n => n * n);
            Console.WriteLine("\nSquares:");
            foreach (var n in squares)
                Console.WriteLine(n);

            var count = numbers.Count(n => n % 5 == 0);
            Console.WriteLine("\nCount divisible by 5: " + count);

        }

    }
}
