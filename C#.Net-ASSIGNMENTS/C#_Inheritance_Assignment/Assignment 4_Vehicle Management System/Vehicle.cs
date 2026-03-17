using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4_Vehicle_Management_System
{
    internal class Vehicle
    {
        public string VehicleNumber { get; set; }
        public string Brand {  get; set; }

        public void StartVehicle()
        {
            Console.WriteLine("Vehicle started");
        }
    }
}
