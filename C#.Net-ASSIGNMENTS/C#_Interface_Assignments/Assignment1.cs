namespace C__Interface_Assignments
{
    internal class Assignment1
    {
        static void Main(string[] args)
        {
            TCS tcsEmp = new TCS(1, "Ravi", "IT", "Developer", 50000);

            Console.WriteLine("TCS Employee");
            Console.WriteLine($"ID: {tcsEmp.EmpId}");
            Console.WriteLine($"Name: {tcsEmp.Name}");
            Console.WriteLine($"Dept: {tcsEmp.Dept}");
            Console.WriteLine($"Desg: {tcsEmp.Desg}");
            Console.WriteLine($"Salary: {tcsEmp.Salary}");
            Console.WriteLine($"PF: {tcsEmp.EmployeePF(tcsEmp.Salary)}");
            Console.WriteLine($"Leave: {tcsEmp.LeaveDetails()}");
            Console.WriteLine($"Gratuity: {tcsEmp.GratuityAmount(12, tcsEmp.Salary)}");

            Console.WriteLine();

            Accenture accEmp = new Accenture(2, "Kiran", "HR", "Manager", 40000);

            Console.WriteLine("Accenture Employee");
            Console.WriteLine($"ID: {accEmp.EmpId}");
            Console.WriteLine($"Name: {accEmp.Name}");
            Console.WriteLine($"Dept: {accEmp.Dept}");
            Console.WriteLine($"Desg: {accEmp.Desg}");
            Console.WriteLine($"Salary: {accEmp.Salary}");
            Console.WriteLine($"PF: {accEmp.EmployeePF(accEmp.Salary)}");
            Console.WriteLine($"Leave: {accEmp.LeaveDetails()}");
            Console.WriteLine($"Gratuity: {accEmp.GratuityAmount(12, accEmp.Salary)}");
        }
    }
}
