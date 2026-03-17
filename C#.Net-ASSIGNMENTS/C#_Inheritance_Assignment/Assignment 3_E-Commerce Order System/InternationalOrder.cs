using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3_E_Commerce_Order_System
{
    internal class InternationalOrder : Order
    {
        public override double CalculateShippingCost()
        {
            return 500;
        }
    }
}
