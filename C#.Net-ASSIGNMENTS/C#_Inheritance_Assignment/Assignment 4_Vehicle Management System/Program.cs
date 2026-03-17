namespace Assignment_4_Vehicle_Management_System
{
    internal class Program
    {
        static void Main()
        {
            ElectricCar ec = new ElectricCar
            {
                VehicleNumber = "AP01AB1234",
                Brand = "Tesla",
                FuelType = "Electric",
                BatteryCapacity = 75
            };

            ec.StartVehicle();

            Console.WriteLine("Vehicle No: " + ec.VehicleNumber);
            Console.WriteLine("Brand: " + ec.Brand);
            Console.WriteLine("Fuel Type: " + ec.FuelType);
            Console.WriteLine("Battery: " + ec.BatteryCapacity + " kWh");
        }
    }
}
