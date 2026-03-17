namespace Q2_Ticket_Booking_with_Exception
{

    class TicketException : Exception
    {
        public TicketException(string message) : base(message)
        {
        }
    }

    internal class Program
    {
        static void Main()
        {
            int availableTickets = 15;

            Console.Write("Do you want to book tickets? (yes/no): ");
            string choice = Console.ReadLine()!;

            if (choice.ToLower() == "yes")
            {
                Console.Write("Enter number of tickets: ");
                int tickets = Convert.ToInt32(Console.ReadLine());

                try
                {
                    if (tickets > availableTickets)
                    {
                        throw new TicketException("Tickets not available!");
                    }
                    else
                    {
                        availableTickets -= tickets;
                        Console.WriteLine("Tickets booked successfully!");
                        Console.WriteLine("Remaining Tickets: " + availableTickets);
                    }
                }
                catch (TicketException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Thank you!");
            }

        }
    }
}

