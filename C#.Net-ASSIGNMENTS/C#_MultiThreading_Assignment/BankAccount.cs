using System;
using System.Collections.Generic;
using System.Text;

namespace C__MultiThreading_Assignment
{
    internal class BankAccount
    {
        public int Balance = 1000;

        private object lockObj = new object();
        public void WithdrawWithoutLock(int amount)
        {
            if (Balance >= amount)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " is withdrawing " + amount);

                Thread.Sleep(500);

                Balance -= amount;

                Console.WriteLine(Thread.CurrentThread.Name + " remaining balance: " + Balance);
            }
            else
            {
                Console.WriteLine(Thread.CurrentThread.Name + " insufficient balance!");
            }
        }
        public void WithdrawWithLock(int amount)
        {
            lock (lockObj)
            {
                if (Balance >= amount)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " is withdrawing " + amount);

                    Thread.Sleep(500);

                    Balance -= amount;

                    Console.WriteLine(Thread.CurrentThread.Name + " remaining balance: " + Balance);
                }
                else
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " insufficient balance!");
                }
            }
        }
    }
}
