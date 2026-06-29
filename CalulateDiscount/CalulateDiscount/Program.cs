using System;

namespace CalulateDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the total purchase ammount");
            double purchaseAmount = Convert.ToDouble(Console.ReadLine());
            double discountRate = 0.0;
            double discountAmount = 0.0;
            double finalAmount = 0.0;

            if (purchaseAmount >= 10000)
            {
                discountRate = 20.0;
            }
            else if (purchaseAmount >= 5000)
            {
                discountRate = 15.0;
            }
            else if (purchaseAmount >= 2000)
            {
                discountRate = 10.0;
            }
            else if (purchaseAmount >= 1000)
            {
                discountRate = 5.0;
            }
            else
            {
                discountRate = 0.0;
            }

            discountAmount = (purchaseAmount * discountRate) / 100;
            finalAmount = purchaseAmount - discountAmount;

            Console.WriteLine("----Receipt Details----");
            Console.WriteLine("Original Purchase Amount: " + purchaseAmount);
            Console.WriteLine("Discount Applied: " + discountRate);
            Console.WriteLine("Saved Amount: " + discountAmount);
            Console.WriteLine("Final Amount to be Paid: " + finalAmount);

            Console.ReadKey();

        }
    }
}
   