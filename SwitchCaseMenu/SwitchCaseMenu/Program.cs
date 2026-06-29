using System;

namespace SwitchCaseMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("list of devices");
            Console.WriteLine("1. Smart Phone");
            Console.WriteLine("2. Laptop");
            Console.WriteLine("3. EarBuds");
            Console.WriteLine("4. Smart Watch");

            Console.WriteLine("Enter value to show price of device: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Price of Smart Phone is $500");
                    break;
                case 2:
                    Console.WriteLine("Price of Laptop is $1000");
                    break;
                case 3:
                    Console.WriteLine("Price of EarBuds is $150");
                    break;
                case 4:
                    Console.WriteLine("Price of Smart Watch is $300");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }

}