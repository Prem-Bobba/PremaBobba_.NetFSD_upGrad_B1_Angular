using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3_E_Commerce_Order_System
{
    internal class Order
    {
        public int OrderId { get; set; }
        public double OrderAmount { get; set; }

       
        public virtual double CalculateShippingCost()
        {
            return 50; 
        }
    }
}
