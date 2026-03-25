using System;
using System.Collections.Generic;
using System.Text;

namespace C__FileHandling_Assignments
{
    internal class Assignment2
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\nStudent Report Card");
                Console.WriteLine();
                Console.WriteLine("1. Create Report");
                Console.WriteLine("2. View Report");
                Console.WriteLine("3. Exit");
                Console.WriteLine();
                Console.Write("Enter choice: ");
                Console.WriteLine();

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CreateReport();
                        break;

                    case 2:
                        ViewReport();
                        break;

                    case 3:
                        return;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }

        static void CreateReport()
        {
            try
            {
                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Enter Roll Number: ");
                string roll = Console.ReadLine();

                Console.WriteLine();

                int m1 = GetValidMarks("Enter Marks 1: ");
                int m2 = GetValidMarks("Enter Marks 2: ");
                int m3 = GetValidMarks("Enter Marks 3: ");

                int total = m1 + m2 + m3;
                double avg = total / 3.0;

                string grade;

                if (avg >= 75)
                    grade = "A";
                else if (avg >= 50)
                    grade = "B";
                else if (avg >= 35)
                    grade = "C";
                else
                    grade = "Fail";

                string filePath = roll + ".txt";

                string content =
    $@"Student Name: {name}
Roll Number: {roll}
Marks: {m1}, {m2}, {m3}
Total: {total}
Average: {avg}
Grade: {grade}";

                File.WriteAllText(filePath, content);

                Console.WriteLine("✅ Report generated successfully!");

                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error: " + ex.Message);
                Console.WriteLine();
            }
        }

        static void ViewReport()
        {
            try
            {
                Console.Write("Enter Roll Number: ");
                Console.WriteLine();
                string roll = Console.ReadLine();

                string filePath = roll + ".txt";

                if (File.Exists(filePath))
                {
                    string content = File.ReadAllText(filePath);

                    Console.WriteLine("\nStudent Report");
                    Console.WriteLine() ;
                    Console.WriteLine(content);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("❌ Report not found!");
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error: " + ex.Message);
            }
        }

        static int GetValidMarks(string message)
        {
            int marks;

            while (true)
            {
                Console.Write(message);

                if (int.TryParse(Console.ReadLine(), out marks) && marks >= 0 && marks <= 100)
                {
                    return marks;
                }
                else
                {
                    Console.WriteLine("❌ Invalid marks! Enter 0–100.");
                }
            }
        }
    }
}
