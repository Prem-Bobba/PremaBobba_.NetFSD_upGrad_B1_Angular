using System;
using System.Collections.Generic;
using System.Text;

namespace Q1_BankAccount_with_User_Defined_Exception
{
    internal class BankAccount
    {
        public int AccountNumber;
        public string Name = "";
        public static double balance = 1000; // Initial balance
        public char transactionType;
        public double amount;

        public void Transaction()
        {
            if (transactionType == 'd' || transactionType == 'D') // Deposit
            {
                balance += amount;
                Console.WriteLine("Amount Deposited: " + amount);
            }
            else if (transactionType == 'c' || transactionType == 'C') // Withdraw
            {
                if (balance - amount < 500)
                {
                    throw new CheckBalanceException("Minimum balance should be 500!");
                }
                else
                {
                    balance -= amount;
                    Console.WriteLine("Amount Withdrawn: " + amount);
                }
            }
            else
            {
                Console.WriteLine("Invalid Transaction Type!");
            }

            Console.WriteLine("Current Balance: " + balance);
        }
    }
}
