using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_LINQ_Assignments
{
    internal class Assignment7
    {
        static void Main()
        {
            List<Product> products = new List<Product>()
        {
            new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 80000, Stock = 5 },
            new Product { Id = 2, Name = "Mouse", Category = "Electronics", Price = 500, Stock = 50 },
            new Product { Id = 3, Name = "Shirt", Category = "Clothing", Price = 1500, Stock = 20 },
            new Product { Id = 4, Name = "Jeans", Category = "Clothing", Price = 2500, Stock = 8 },
            new Product { Id = 5, Name = "Mobile", Category = "Electronics", Price = 60000, Stock = 0 }
        };

            var lowStock = products.Where(p => p.Stock < 10);
            Console.WriteLine("Low Stock Products:");
            foreach (var p in lowStock)
                Console.WriteLine($"{p.Name} - {p.Stock}");

            var top3 = products.OrderByDescending(p => p.Price).Take(3);
            Console.WriteLine("\nTop 3 Expensive:");
            foreach (var p in top3)
                Console.WriteLine($"{p.Name} - {p.Price}");

            var grouped = products.GroupBy(p => p.Category);
            Console.WriteLine("\nGrouped:");
            foreach (var g in grouped)
            {
                Console.WriteLine(g.Key);
                foreach (var p in g)
                    Console.WriteLine("  " + p.Name);
            }

            var totalStock = products.GroupBy(p => p.Category)
            .Select(g => new { g.Key, Total = g.Sum(x => x.Stock) });

            Console.WriteLine("\nTotal Stock:");
            foreach (var t in totalStock)
                Console.WriteLine($"{t.Key} - {t.Total}");

            var outOfStock = products.Any(p => p.Stock == 0);
            Console.WriteLine("\nAny Out of Stock: " + outOfStock);

        }
    }
}
