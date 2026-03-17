using System;
using System.Collections.Generic;
using System.Text;

namespace C__Class_Assignment_1
{
    internal class Billing
    {

        public string PatientName = "";
        public double ConsultationFee;
        public double TestCharges;

        public void CalculateTotalBill()
        {
            double total = ConsultationFee + TestCharges;

            Console.WriteLine("Patient Name: " + PatientName);
            Console.WriteLine("Total Bill: " + total);
        }
    }
}
