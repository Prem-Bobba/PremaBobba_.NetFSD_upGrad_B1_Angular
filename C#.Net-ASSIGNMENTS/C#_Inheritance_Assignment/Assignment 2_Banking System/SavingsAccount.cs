using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2_Banking_System
{
    internal class SavingsAccount : Account
    {
        public new void CalculateInterest()
        {
            Console.WriteLine("Savings account interest calculation");
        }
    }
}
