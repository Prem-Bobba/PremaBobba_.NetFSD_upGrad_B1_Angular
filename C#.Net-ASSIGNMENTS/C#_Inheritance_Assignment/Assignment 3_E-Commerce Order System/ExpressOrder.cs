using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3_E_Commerce_Order_System
{
    internal class ExpressOrder : Order
    {
        public override double CalculateShippingCost()
        {
            return 100;
        }
    }
}
