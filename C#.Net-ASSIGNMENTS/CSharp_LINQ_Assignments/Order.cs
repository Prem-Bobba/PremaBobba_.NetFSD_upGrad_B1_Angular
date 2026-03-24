using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_LINQ_Assignments
{
    internal class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public double Amount { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalAmount { get; set; }
    }
}
