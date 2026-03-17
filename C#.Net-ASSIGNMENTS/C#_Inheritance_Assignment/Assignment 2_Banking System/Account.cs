using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2_Banking_System
{
    internal class Account
    {
        public int AccountNumber { get; set; }
        public double Balance { get; set; }

        public void CalculateInterest()
        {
            Console.WriteLine("Base account interest calculation");
        }
    }
}
