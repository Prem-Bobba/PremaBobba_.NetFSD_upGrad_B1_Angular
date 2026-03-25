using System;
using System.Collections.Generic;
using System.Text;

namespace C__Collections_Assignments
{
    internal class Assignment5
    {
        static void Main()
        {
            Queue<Patient> patients = new Queue<Patient>();

            Console.Write("Enter number of patients: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Patient p = new Patient();

                Console.Write("\nEnter Patient Id: ");
                p.Id = int.Parse(Console.ReadLine());

                Console.Write("Enter Patient Name: ");
                p.Name = Console.ReadLine();

                Console.Write("Enter Disease: ");
                p.Disease = Console.ReadLine();

                patients.Enqueue(p);
            }

            Console.Write("\nHow many patients to serve: ");
            int serveCount = int.Parse(Console.ReadLine());

            Console.WriteLine("\nServing Patients:");
            for (int i = 0; i < serveCount; i++)
            {
                if (patients.Count > 0)
                {
                    var served = patients.Dequeue();
                    Console.WriteLine($"Served: {served.Name} - {served.Disease}");
                }
                else
                {
                    Console.WriteLine("No more patients in queue");
                    break;
                }
            }

            if (patients.Count > 0)
            {
                var next = patients.Peek();
                Console.WriteLine($"\nNext Patient: {next.Name} - {next.Disease}");
            }
            else
            {
                Console.WriteLine("\nNo patients left");
            }

            Console.WriteLine("\nRemaining Patients:");
            foreach (var p in patients)
            {
                Console.WriteLine($"{p.Id} - {p.Name} - {p.Disease}");
            }
        }
    }
}
