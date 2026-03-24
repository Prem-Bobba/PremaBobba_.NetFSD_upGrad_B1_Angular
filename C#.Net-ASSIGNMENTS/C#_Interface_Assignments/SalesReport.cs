using System;
using System.Collections.Generic;
using System.Text;

namespace C__Interface_Assignments
{
      class SalesReport : Sales, IYearlySales
       
      {
            public override int GetMonthlySales()
            {
                return GetDailySales() * 30;
            }

            public int GetYearlySales()
            {
                return GetMonthlySales() * 12;
            }
      }
    
}
