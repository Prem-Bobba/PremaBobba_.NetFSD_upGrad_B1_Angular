using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_LINQ_Assignments
{
    internal class Assignment5
    {
        static void Main()
        {
            List<Customer> customers = new List<Customer>()
        {
            new Customer { Id = 1, Name = "Ravi" },
            new Customer { Id = 2, Name = "Kiran" },
            new Customer { Id = 3, Name = "Amit" },
            new Customer { Id = 4, Name = "Raj" }
        };

            List<Order> orders = new List<Order>()
        {
            new Order { Id = 1, CustomerId = 1, Amount = 2000 },
            new Order { Id = 2, CustomerId = 1, Amount = 4000 },
            new Order { Id = 3, CustomerId = 2, Amount = 1500 },
            new Order { Id = 4, CustomerId = 3, Amount = 6000 }
        };

           var joinResult = customers.Join(
           orders,
           c => c.Id,
           o => o.CustomerId,
           (c, o) => new { c.Name, o.Amount });

            Console.WriteLine("Customers and Orders Join:");
            foreach (var item in joinResult)
                Console.WriteLine($"{item.Name} - {item.Amount}");

            var totals = orders.GroupBy(o => o.CustomerId)
            .Select(g => new { g.Key, Total = g.Sum(x => x.Amount) });

            Console.WriteLine("\nTotals:");
            foreach (var t in totals)
                Console.WriteLine($"{t.Key} - {t.Total}");

            var high = totals.Where(x => x.Total > 5000);

            Console.WriteLine("\nTotal > 5000:");
            foreach (var h in high)
                Console.WriteLine($"{h.Key} - {h.Total}");

            var noOrders = customers.GroupJoin(
            orders,
            c => c.Id,
            o => o.CustomerId,
            (c, o) => new { c, o })
            .Where(x => !x.o.Any());

            Console.WriteLine("\nNo Orders:");
            foreach (var n in noOrders)
                Console.WriteLine(n.c.Name);

        }
    }
}
