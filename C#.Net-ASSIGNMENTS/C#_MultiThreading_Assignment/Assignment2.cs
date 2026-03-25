using System;
using System.Collections.Generic;
using System.Text;

namespace C__MultiThreading_Assignment
{
    internal class Assignment2
    {
        static void Main()
        {
            Console.WriteLine("Choose Mode:");
            Console.WriteLine();
            Console.WriteLine("1. Without Synchronization");
            Console.WriteLine();
            Console.WriteLine("2. With Synchronization");
            Console.WriteLine();
            int choice = int.Parse(Console.ReadLine());

            BankAccount account = new BankAccount();

            Thread t1, t2, t3;

            if (choice == 1)
            {
                
                t1 = new Thread(() => account.WithdrawWithoutLock(700));
                t2 = new Thread(() => account.WithdrawWithoutLock(700));
                t3 = new Thread(() => account.WithdrawWithoutLock(700));
            }
            else
            {

                t1 = new Thread(() => account.WithdrawWithLock(700));
                t2 = new Thread(() => account.WithdrawWithLock(700));
                t3 = new Thread(() => account.WithdrawWithLock(700));
            }

            t1.Name = "User1";
            t2.Name = "User2";
            t3.Name = "User3";

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine("\nFinal Balance: " + account.Balance);

        }
    }
}
