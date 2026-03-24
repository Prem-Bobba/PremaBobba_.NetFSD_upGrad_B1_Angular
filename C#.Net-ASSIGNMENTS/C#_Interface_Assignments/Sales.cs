using System;
using System.Collections.Generic;
using System.Text;

namespace C__Interface_Assignments
{
    abstract class Sales
    {
        public int GetDailySales()
        {
            return 400;
        }
        public abstract int GetMonthlySales();
    }
}
