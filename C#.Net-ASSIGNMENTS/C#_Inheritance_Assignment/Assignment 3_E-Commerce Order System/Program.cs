namespace Assignment_3_E_Commerce_Order_System
{
    internal class Program
    {
        static void Main()
        {
            List<Order> orders = new List<Order>();

            
            orders.Add(new StandardOrder { OrderId = 1, OrderAmount = 1000 });
            orders.Add(new ExpressOrder { OrderId = 2, OrderAmount = 2000 });
            orders.Add(new InternationalOrder { OrderId = 3, OrderAmount = 3000 });

           
            foreach (Order order in orders)
            {
                Console.WriteLine("Order Id: " + order.OrderId);
                Console.WriteLine("Shipping Cost: " + order.CalculateShippingCost());
                Console.WriteLine();
            }
        }
    }
}
