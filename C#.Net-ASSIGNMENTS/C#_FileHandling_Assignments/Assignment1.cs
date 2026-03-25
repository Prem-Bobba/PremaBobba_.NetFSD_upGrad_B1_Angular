using System;
using System.IO;
using System.Collections.Generic;

namespace C__FileHandling_Assignments
{
    internal class Assignment1
    {
        static string filePath = "employee_log.txt";

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\nEmployee Log Management");
                Console.WriteLine("1. Add Login Entry");
                Console.WriteLine("2. Update Logout Time");
                Console.WriteLine("3. View Logs");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                Console.WriteLine();

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddLogin();
                        break;

                    case 2:
                        UpdateLogout();
                        break;

                    case 3:
                        ViewLogs();
                        break;

                    case 4:
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }

        static void AddLogin()
        {
            try
            {
                Console.Write("Enter Employee ID: ");
                string id = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.WriteLine();

                string loginTime = DateTime.Now.ToString();

                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine($"{id} | {name} | {loginTime} | -");
                }

                Console.WriteLine("✅ Login recorded successfully!");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error: " + ex.Message);
                Console.WriteLine();
            }
            finally
            {
                Console.WriteLine("Add Login Operation Completed");
                Console.WriteLine();
            }
        }

        static void UpdateLogout()
        {
            try
            {
                Console.Write("Enter Employee ID to update logout: ");
                string id = Console.ReadLine();

                if (!File.Exists(filePath))
                {
                    Console.WriteLine("❌ File not found!");
                    return;
                }

                List<string> updatedLines = new List<string>();

                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|');

                        string empId = parts[0].Trim();
                        string name = parts[1].Trim();
                        string login = parts[2].Trim();
                        string logout = parts[3].Trim();

                        if (empId == id && logout == "-")
                        {
                            logout = DateTime.Now.ToString();
                            line = $"{empId} | {name} | {login} | {logout}";
                        }

                        updatedLines.Add(line);
                    }
                }

                File.WriteAllLines(filePath, updatedLines);

                Console.WriteLine("✅ Logout updated successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Update Operation Completed");
            }
        }

        static void ViewLogs()
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("❌ No logs found!");
                    return;
                }

                Console.WriteLine("\n===== Employee Logs =====");

                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("View Operation Completed");
            }

        }
    }
}
