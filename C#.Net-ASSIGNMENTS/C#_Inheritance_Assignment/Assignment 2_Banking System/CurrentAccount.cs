using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2_Banking_System
{
    internal class CurrentAccount : Account
    {
        public new void CalculateInterest()
        {
            Console.WriteLine("Current account interest calculation");
        }
    }
}
