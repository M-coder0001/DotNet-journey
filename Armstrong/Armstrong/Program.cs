using System;

namespace Armstong
{
    class Program
    {
        static void Main(string[] args)
        {
            int rem,num, temp, sum = 0;

            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            temp = num;

            while (num > 0)
            {
                rem = num % 10;
                sum = sum + (rem * rem * rem);
                num = num / 10;
            }
            
            if (temp == sum)
            {
                Console.WriteLine("{0} is an Armstrong number.", temp);
            }
            else
            {
                Console.WriteLine("{0} is not an Armstrong number.", temp);
            }

            Console.ReadKey();
        }
    }
}