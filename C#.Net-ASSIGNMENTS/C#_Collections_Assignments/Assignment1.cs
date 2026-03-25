namespace C__Collections_Assignments
{
    internal class Assignment1
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
        {
            new Product { Id = 1, Name = "Laptop", Price = 50000, Category = "Electronics" },
            new Product { Id = 2, Name = "Mobile", Price = 20000, Category = "Electronics" },
            new Product { Id = 3, Name = "Shoes", Price = 1500, Category = "Fashion" },
            new Product { Id = 4, Name = "Watch", Price = 3000, Category = "Accessories" },
            new Product { Id = 5, Name = "TV", Price = 40000, Category = "Electronics" },
            new Product { Id = 6, Name = "Bag", Price = 1200, Category = "Fashion" },
            new Product { Id = 7, Name = "Headphones", Price = 2500, Category = "Electronics" },
            new Product { Id = 8, Name = "Keyboard", Price = 800, Category = "Electronics" },
            new Product { Id = 9, Name = "Chair", Price = 3500, Category = "Furniture" },
            new Product { Id = 10, Name = "Table", Price = 7000, Category = "Furniture" }
        };

            Console.WriteLine("All Products:");
            foreach (var p in products)
                Console.WriteLine($"{p.Id} - {p.Name} - {p.Price} - {p.Category}");

            var costly = products.Where(p => p.Price > 1000);

            Console.WriteLine("\nPrice > 1000:");
            foreach (var p in costly)
                Console.WriteLine($"{p.Name} - {p.Price}");

            var asc = products.OrderBy(p => p.Price);
            Console.WriteLine("\nAscending:");
            foreach (var p in asc)
                Console.WriteLine($"{p.Name} - {p.Price}");

            var desc = products.OrderByDescending(p => p.Price);
            Console.WriteLine("\nDescending:");
            foreach (var p in desc)
                Console.WriteLine($"{p.Name} - {p.Price}");

            var remove = products.FirstOrDefault(p => p.Id == 3);
            if (remove != null) products.Remove(remove);

            Console.WriteLine("\nAfter Remove:");
            foreach (var p in products)
                Console.WriteLine($"{p.Id} - {p.Name}");

            var electronics = products.Where(p => p.Category == "Electronics");

            Console.WriteLine("\nElectronics:");
            foreach (var p in electronics)
                Console.WriteLine($"{p.Name} - {p.Price}");
        }
    }
}
