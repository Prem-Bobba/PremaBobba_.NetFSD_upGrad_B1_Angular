using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6_Furniture_System
{
    internal class Chair : Furniture
    {
        public string ChairType;   // Wood/Steel/Plastic
        public string Purpose;     // Home/Office
        public string MaterialType;
        public double Rate;

        public override void GetData()
        {
            base.GetData();

            FurnitureType = "Chair";

            Console.Write("Enter Chair Type (Wood/Steel/Plastic): ");
            ChairType = Console.ReadLine();

            Console.Write("Enter Purpose (Home/Office): ");
            Purpose = Console.ReadLine();

            // Based on type
            if (ChairType == "Wood")
            {
                Console.Write("Enter Wood Type (Teak/Rose): ");
                MaterialType = Console.ReadLine();
            }
            else if (ChairType == "Steel")
            {
                Console.Write("Enter Steel Type (Gray/Green/Brown): ");
                MaterialType = Console.ReadLine();
            }
            else if (ChairType == "Plastic")
            {
                Console.Write("Enter Color (Green/Red/Blue/White): ");
                MaterialType = Console.ReadLine();
            }

            Console.Write("Enter Rate: ");
            Rate = Convert.ToDouble(Console.ReadLine());

            TotalAmt = Qty * Rate;
        }

        public override void ShowData()
        {
            base.ShowData();

            Console.WriteLine("Furniture Type: " + FurnitureType);
            Console.WriteLine("Chair Type: " + ChairType);
            Console.WriteLine("Purpose: " + Purpose);
            Console.WriteLine("Material: " + MaterialType);
        }

    }
}
