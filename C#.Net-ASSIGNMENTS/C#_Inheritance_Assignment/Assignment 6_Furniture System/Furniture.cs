using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6_Furniture_System
{
    internal class Furniture
    {
        public int OrderId;
        public string OrderDate;
        public string FurnitureType;
        public int Qty;
        public double TotalAmt;
        public string PaymentMode;

        public virtual void GetData()
        {
            Console.Write("Enter Order Id: ");
            OrderId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Order Date: ");
            OrderDate = Console.ReadLine();

            Console.Write("Enter Quantity: ");
            Qty = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Payment Mode (Credit/Debit): ");
            PaymentMode = Console.ReadLine();
        }

        public virtual void ShowData()
        {
            Console.WriteLine("Order Id: " + OrderId);
            Console.WriteLine("Order Date: " + OrderDate);
            Console.WriteLine("Quantity: " + Qty);
            Console.WriteLine("Payment Mode: " + PaymentMode);
            Console.WriteLine("Total Amount: " + TotalAmt);
        }
    }
}
