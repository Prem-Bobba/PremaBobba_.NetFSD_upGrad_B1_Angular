namespace Assignment_6_Furniture_System
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("1. Chair");
            Console.WriteLine("2. Cot");
            Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Furniture f;

            if (choice == 1)
                f = new Chair();
            else
                f = new Cot();

            f.GetData();
            Console.WriteLine("\n--- Details ---");
            f.ShowData();
        }
    }
}
