namespace Q1_BankAccount_with_User_Defined_Exception
{

    class CheckBalanceException : Exception
    {
        public CheckBalanceException(string message) : base(message)
        {
        }
    }

    class Program
    {
        static void Main()
        {
            BankAccount b = new BankAccount();

            Console.Write("Enter Account Number: ");
            b.AccountNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            b.Name = Console.ReadLine()!;

            Console.Write("Enter Transaction Type (d = deposit, c = withdraw): ");
            b.transactionType = Convert.ToChar(Console.ReadLine()!);

            Console.Write("Enter Amount: ");
            b.amount = Convert.ToDouble(Console.ReadLine());

            try
            {
                b.Transaction();
            }
            catch (CheckBalanceException ex)
            {
                Console.WriteLine("Exception Occurred: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Error: " + ex.Message);
            }
        }
    }
}
