using System;

namespace Properties2
{
    class BankAccount
    {
        private double balance;

        public double Balance
        {
            get 
            { 
                return balance; 
            }
            set
            {
                if (value > 0)
                {
                    balance = value;
                }
                else
                {
                    Console.WriteLine("Balance cannot be negative.");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.Balance = 0; // Set the balance to a positive value
            Console.WriteLine($"Balance: {account.Balance}");
        }
    }
}