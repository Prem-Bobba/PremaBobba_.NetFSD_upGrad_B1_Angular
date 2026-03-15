using System;

namespace C__Basic_Assignment_2
{
    class DisplayMessageProgram
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the world of C#");
        }
    }

    class GreetingProgram
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine("Hi! " + args[0]);
                Console.WriteLine("Welcome to the world of C#");
            }
            else
            {
                Console.WriteLine("Enter username.");
            }
        }
    }

    class NumbersBetweenProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());


            for (int i = num1 + 1; i < num2; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

    class EvenOddProgram
    {
        static void Main()
        {
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine("Even Number");
            else
                Console.WriteLine("Odd Number");
        }
    }
    class OddEvenCountProgram
    {
        static void Main()
        {
            int n, number;
            int evenCount = 0;
            int oddCount = 0;

            Console.WriteLine("Enter numbers : ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter number " + i + ": ");
                number = Convert.ToInt32(Console.ReadLine());

                if (number % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            Console.WriteLine("Total Even Numbers: " + evenCount);
            Console.WriteLine("Total Odd Numbers: " + oddCount);
        }
    }

    class TemperatureProgram
    {
        static void Main()
        {
            double fahrenheit, celsius;

            Console.WriteLine("Enter temperature in Fahrenheit: ");
            fahrenheit = Convert.ToDouble(Console.ReadLine());

            celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine("Temperature in Celsius: " + celsius);
        }

    }
    class ShopProgram
    {
        static void Main()
        {
            int product, quantity;
            double total = 0;

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Enter Product Number: ");
                product = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Quantity Sold: ");
                quantity = Convert.ToInt32(Console.ReadLine());

                if (product == 1)
                    total += quantity * 22.5;
                else if (product == 2)
                    total += quantity * 44.50;
                else if (product == 3)
                    total += quantity * 9.98;
            }

            Console.WriteLine("Total Price: " + total);
        }

    }
    class SquareSeriesProgram
    {
        static void Main()
        {
            for (int i = 0; i <= 25; i++)
            {
                Console.WriteLine(i * i + " ");
            }
        }
    }
    class FactorialProgram
    {
        static void Main()
        {
            int num; 
                
            long fact = 1;

            Console.WriteLine("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine("Factorial = " + fact);
        }
    }

    class FibonacciProgram
    {
        static void Main()
        {
            int a = 0, b = 1, c;

            Console.Write(a + " " + b + " ");

            c = a + b;

            while (c <= 40)
            {
                Console.Write(c + " ");
                a = b;
                b = c;
                c = a + b;
            }
        }
    }

    class TableProgram
    {
        static void Main()
        {
            int num;

            Console.WriteLine("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine()); 

            for (int i = 1; i<= 20; i++)
            {
                Console.WriteLine(num + " X " + i + " = " + (num * i));
            }
        }
    }

    class DivisibleBySeven
    {
        static void Main()
        {
            for (int i = 200; i <= 300; i++)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i + " ");
                }
            }
        }
    }
    class LargestNumber
    {
        static void Main()
        {
            int a, b, c;

            Console.WriteLine("Enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third number: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("Largest number is: " + a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("Largest number is: " + b);
            }
            else
            {
                Console.WriteLine("Largest number is: " + c);
            }
        }
    }
    class SmallestNumber
    {
        static void Main()
        {
            int num, smallest;

            Console.WriteLine("Enter first number: ");
            smallest = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= 5; i++)
            {
                Console.WriteLine("Enter number " + i + ": ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num < smallest)
                {
                    smallest = num;
                }
            }

            Console.WriteLine("Smallest number is: " + smallest);
        }
    }
    class MarksProgram
    {
        static void Main()
        {
            int[] marks = new int[10];
            int total = 0, min, max;

            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter mark " + (i + 1) + ": ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
                total += marks[i];
            }

            
            min = marks[0];
            max = marks[0];

            for (int i = 1; i < 10; i++)
            {
                if (marks[i] < min)
                    min = marks[i];

                if (marks[i] > max)
                    max = marks[i];
            }

            double average = total / 10.0;

            Console.WriteLine("Total = " + total);
            Console.WriteLine("Average = " + average);
            Console.WriteLine("Minimum Marks = " + min);
            Console.WriteLine("Maximum Marks = " + max);

            
            Array.Sort(marks);
            Console.WriteLine("Marks in Ascending Order:");
            foreach (int m in marks)
            {
                Console.WriteLine(m + " ");
            }

           
            Array.Reverse(marks);
            Console.WriteLine("Marks in Descending Order:");
            foreach (int m in marks)
            {
                Console.Write(m + " ");
            }
        }
    }

    class WordLengthProgram
    {
        static void Main()
        {
            string word;

            Console.WriteLine("Enter a word: ");
            word = Console.ReadLine();

            Console.WriteLine("Length of the word: " + word.Length);
        }
    }

    class WordReverseProgram
    {
        static void Main()
        {
            string word, reverse = "";

            Console.WriteLine("Enter a word: ");
            word = Console.ReadLine();

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverse += word[i];
            }

            Console.WriteLine("Reversed word: " + reverse);
        }
    }

    class CompareWordsProgram
    {
        static void Main()
        {
            string word1, word2;

            Console.WriteLine("Enter first word: ");
            word1 = Console.ReadLine();

            Console.WriteLine("Enter second word: ");
            word2 = Console.ReadLine();

            if (word1 == word2)
            {
                Console.WriteLine("Both words are same.");
            }
            else
            {
                Console.WriteLine("Words are different.");
            }
        }
    }

    class PalindromeProgram
    {
        static void Main()
        {
            string word, reverse = "";

            Console.WriteLine("Enter a word: ");
            word = Console.ReadLine();

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverse = reverse + word[i];
            }

            if (word == reverse)
            {
                Console.WriteLine("The word is a Palindrome.");
            }
            else
            {
                Console.WriteLine("The word is not a Palindrome.");
            }
        }
    }
}
