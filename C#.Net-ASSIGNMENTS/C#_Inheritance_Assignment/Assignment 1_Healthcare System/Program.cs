namespace Assignment_1_Healthcare_System
{
    internal class Program
    {
        static void Main()
        {

            Staff s;

            s = new Doctor
            {
                StaffId = 1,
                Name = "Dr. Ravi",
                BaseSalary = 30000,
                ConsultationFee = 10000
            };
            Console.WriteLine("Doctor Salary: " + s.CalculateSalary());

            s = new Nurse
            {
                StaffId = 2,
                Name = "Anjali",
                BaseSalary = 20000,
                NightShiftAllowance = 5000
            };
            Console.WriteLine("Nurse Salary: " + s.CalculateSalary());

            s = new LabTechnician
            {
                StaffId = 3,
                Name = "John",
                BaseSalary = 18000,
                EquipmentAllowance = 3000
            };
            Console.WriteLine("Lab Technician Salary: " + s.CalculateSalary());

        }
    }
}
