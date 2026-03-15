using System;
using System.ComponentModel.Design;

namespace C__Basic_Assignment_1
{
    class DivisionProgram
    {
        static void Main()
        {
            int num1, num2, quotient;

            Console.WriteLine("Enter first number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            quotient = num1 / num2;

            Console.WriteLine("Quotient is: " + quotient);


        }
    }

    class DistanceProgram
    {
        static void Main()
        {
            double km, meters;

            Console.WriteLine("Enter distance in kilometers:");
            km = Convert.ToDouble(Console.ReadLine());

            meters = km * 1000;

            Console.WriteLine("Distance in meters is: " + meters);
        }
    }

    class SumandAverageProgram
    {
        static void Main()
        {
            int number, sum = 0;
            double average;

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Enter number " + i + ":");
                number = Convert.ToInt32(Console.ReadLine());

                sum = sum + number;
            }

            average = sum / 5;

            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Average = " + average);


        }

    }

    class OddorEvenNumberProgram
    {
        static void Main()
        {

            int number;

            Console.WriteLine("Enter number : ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)

            {

                Console.WriteLine("The Number is Even");

            }

            else
            {
                Console.WriteLine("The Number is Odd");
            }

        }

    }

    class HighestNumberProgram
    {
        static void Main()

        {
            int num1, num2;

            Console.WriteLine("Enter Number 1 : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 2 : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("Number 1 is the Highest");
            }
            else
            {
                Console.WriteLine("Number 2 is the Highest");
            }
        }
    }

    class AreaOfRectangleandSquare
    {
        static void Main()
        {
            int length, width, side, area;

            Console.WriteLine("Enter length : ");
            length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter width : ");
            width = Convert.ToInt32(Console.ReadLine());

            area = length * width;

            Console.WriteLine("Area of rectangle = " + area);

            Console.WriteLine("Enter Side : ");
            side = Convert.ToInt32(Console.ReadLine());

            area = side * side;

            Console.WriteLine("Area of Square = " + area);



        }
    }

    class TimeTakenForTheJourneyProgram
    {
        static void Main()
        {
            double distance, speed, time;

            Console.WriteLine("Enter Distance : ");
            distance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Speed : ");
            speed = Convert.ToDouble(Console.ReadLine());

            time = distance / speed;

            Console.WriteLine("Time taken for the journey = " + time);
        }
    }

    class VowelorConsonantProgram
    {
        static void Main()
        {
            string text;
            char ch;

            Console.WriteLine("Enter a string : ");
            text = Console.ReadLine()!;

            ch = text[2];

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("It is a vowel");
            }
            else
            {
                Console.WriteLine("It is a Consonant");
            }

        }

    }
}