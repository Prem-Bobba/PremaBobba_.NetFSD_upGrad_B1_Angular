namespace Assignment_2_Banking_System
{
    internal class Program
    {
        static void Main()
        {
            Account acc = new SavingsAccount();

            acc.CalculateInterest();   

            SavingsAccount sa = new SavingsAccount();

            sa.CalculateInterest();
        }
    }
}
