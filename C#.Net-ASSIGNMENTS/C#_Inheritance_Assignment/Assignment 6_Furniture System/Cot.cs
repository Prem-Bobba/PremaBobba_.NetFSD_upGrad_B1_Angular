using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6_Furniture_System
{
    internal class Cot : Furniture
    {
        public string CotType;     
        public string MaterialType;
        public string Capacity;   
        public double Rate;

        public override void GetData()
        {
            base.GetData();

            FurnitureType = "Cot";

            Console.Write("Enter Cot Type (Wood/Steel): ");
            CotType = Console.ReadLine();

            if (CotType == "Wood")
            {
                Console.Write("Enter Wood Type (Teak/Rose): ");
                MaterialType = Console.ReadLine();
            }
            else if (CotType == "Steel")
            {
                Console.Write("Enter Steel Type (Gray/Green/Brown): ");
                MaterialType = Console.ReadLine();
            }

            Console.Write("Enter Capacity (Single/Double): ");
            Capacity = Console.ReadLine();

            Console.Write("Enter Rate: ");
            Rate = Convert.ToDouble(Console.ReadLine());

            TotalAmt = Qty * Rate;
        }

        public override void ShowData()
        {
            base.ShowData();

            Console.WriteLine("Furniture Type: " + FurnitureType);
            Console.WriteLine("Cot Type: " + CotType);
            Console.WriteLine("Material: " + MaterialType);
            Console.WriteLine("Capacity: " + Capacity);
        }

    }
}
