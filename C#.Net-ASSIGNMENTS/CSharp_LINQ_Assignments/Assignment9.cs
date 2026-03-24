using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_LINQ_Assignments
{
    internal class Assignment9
    {
        static void Main()
        {
            List<Order> orders = new List<Order>()
        {
            new Order { Id = 1, CustomerName = "Ravi", OrderDate = DateTime.Now.AddDays(-10), TotalAmount = 5000 },
            new Order { Id = 2, CustomerName = "Kiran", OrderDate = DateTime.Now.AddDays(-40), TotalAmount = 3000 },
            new Order { Id = 3, CustomerName = "Amit", OrderDate = DateTime.Now.AddDays(-5), TotalAmount = 8000 },
            new Order { Id = 4, CustomerName = "Ravi", OrderDate = DateTime.Now.AddDays(-20), TotalAmount = 2000 },
            new Order { Id = 5, CustomerName = "Raj", OrderDate = DateTime.Now.AddDays(-60), TotalAmount = 7000 },
            new Order { Id = 6, CustomerName = "Amit", OrderDate = DateTime.Now.AddDays(-15), TotalAmount = 6000 }
        };

            var last30 = orders.Where(o => o.OrderDate >= DateTime.Now.AddDays(-30));

            Console.WriteLine("Last 30 Days Orders:");
            foreach (var o in last30)
                Console.WriteLine($"{o.CustomerName} - {o.TotalAmount}");

            var monthly = orders.GroupBy(o => new { o.OrderDate.Year, o.OrderDate.Month })
                .Select(g => new { g.Key.Year, g.Key.Month, Total = g.Sum(x => x.TotalAmount) });

            Console.WriteLine("\nMonthly Sales:");
            foreach (var m in monthly)
                Console.WriteLine($"{m.Year}-{m.Month} : {m.Total}");

            var top = orders.GroupBy(o => o.CustomerName)
                .Select(g => new { g.Key, Total = g.Sum(x => x.TotalAmount) })
                .OrderByDescending(x => x.Total)
                .Take(5);

            Console.WriteLine("\nTop Customers:");
            foreach (var t in top)
                Console.WriteLine($"{t.Key} - {t.Total}");

            var highest = orders.GroupBy(o => new { o.OrderDate.Year, o.OrderDate.Month })
                .Select(g => new
                {
                    g.Key.Year,
                    g.Key.Month,
                    Max = g.OrderByDescending(x => x.TotalAmount).First()
                });

            Console.WriteLine("\nHighest Order per Month:");
            foreach (var h in highest)
                Console.WriteLine($"{h.Year}-{h.Month} : {h.Max.CustomerName} - {h.Max.TotalAmount}");

        }
    }
}
