using System;
using System.Collections.Generic;
using System.Text;

namespace C__Interface_Assignments
{
    internal class Assignment2
    {
        static void Main(string[] args)
        {
            SalesReport report = new SalesReport();

            Console.WriteLine("Daily sales: Rs." + report.GetDailySales());
            Console.WriteLine("Monthly sales: Rs." + report.GetMonthlySales());
            Console.WriteLine("Annual sales: Rs." + report.GetYearlySales());
        }
    }
}
