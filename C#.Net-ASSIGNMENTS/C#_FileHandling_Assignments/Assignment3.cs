using System;
using System.Collections.Generic;
using System.Text;

namespace C__FileHandling_Assignments
{
    internal class Assignment3
    {
        static void Main()
        {
            string filePath = "notes.txt";

            while (true)
            {
                Console.WriteLine("\nMINI NOTEPAD");
                Console.WriteLine();
                Console.WriteLine("1. Create New File");
                Console.WriteLine("2. Write to File");
                Console.WriteLine("3. Read File");
                Console.WriteLine("4. Append Text");
                Console.WriteLine("5. Delete File");
                Console.WriteLine("6. Exit");
                Console.WriteLine();
                Console.Write("Enter choice: ");
                Console.WriteLine();

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CreateFile(filePath);
                        break;

                    case 2:
                        WriteFile(filePath);
                        break;

                    case 3:
                        ReadFile(filePath);
                        break;

                    case 4:
                        AppendFile(filePath);
                        break;

                    case 5:
                        DeleteFile(filePath);
                        break;

                    case 6:
                        return;

                    default:
                        Console.WriteLine("Invalid choice!");
                        Console.WriteLine();
                        break;
                }
            }
        }
        static void CreateFile(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    FileStream fs = new FileStream(filePath, FileMode.Create);
                    fs.Close();

                    Console.WriteLine("✅ File created successfully!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("⚠ File already exists!");
                    Console.WriteLine();
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("❌ No permission to create file!");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error: " + ex.Message);
                Console.WriteLine();
            }
        }
        static void WriteFile(string filePath)
        {
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    Console.WriteLine("Enter text (type 'end' to stop):");
                    Console.WriteLine();
                    while (true)
                    {
                        string line = Console.ReadLine();

                        if (line.ToLower() == "end")
                            break;

                        sw.WriteLine(line);
                    }
                }

                Console.WriteLine("✅ Data written successfully!");
                Console.WriteLine();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("❌ File not found!");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("❌ No permission to write!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error: " + ex.Message);
            }
        }
        static void ReadFile(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("❌ File does not exist!");
                    Console.WriteLine();
                    return;
                }

                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                using (StreamReader sr = new StreamReader(fs))
                {
                    Console.WriteLine("\nFILE CONTENT");
                    Console.WriteLine();

                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("❌ File not found!");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("❌ No permission to read!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error: " + ex.Message);
            }
        }

        static void AppendFile(string filePath)
        {
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Append))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    Console.WriteLine("Enter text to append (type 'end' to stop):");
                    Console.WriteLine();

                    while (true)
                    {
                        string line = Console.ReadLine();

                        if (line.ToLower() == "end")
                            break;

                        sw.WriteLine(line);
                    }
                }

                Console.WriteLine("✅ Data appended successfully!");
                Console.WriteLine();
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("❌ No permission to append!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error: " + ex.Message);
            }
        }
        static void DeleteFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    Console.WriteLine("✅ File deleted successfully!");
                }
                else
                {
                    Console.WriteLine("❌ File not found!");
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("❌ No permission to delete!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error: " + ex.Message);
            }
        }

    }
}
