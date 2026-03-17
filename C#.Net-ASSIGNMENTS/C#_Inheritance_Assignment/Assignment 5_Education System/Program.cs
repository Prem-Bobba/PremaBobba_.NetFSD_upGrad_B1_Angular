namespace Assignment_5_Education_System
{
    internal class Program
    {
        static void Main()
        {
            Student[] students = new Student[]
        {
            new SchoolStudent(1, "Ravi", 45),
            new CollegeStudent(2, "Sita", 55),
            new OnlineStudent(3, "John", 58)
        };
            foreach (Student s in students)
            {
                Console.WriteLine("Id: " + s.StudentId);
                Console.WriteLine("Name: " + s.Name);
                Console.WriteLine("Marks: " + s.Marks);
                Console.WriteLine("Result: " + s.CalculateGrade());
                Console.WriteLine();
            }
        }
    }
}
