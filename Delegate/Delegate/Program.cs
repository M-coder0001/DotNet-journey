using System;

namespace Delegate
{
    public delegate int Calc(int n);

    class Program
    {
        static int number = 100;

        public static int add(int n)
        {
            number = number + n;
            return number;
        }
        public static int mul(int n)
        {
            number = number * n;
            return number;
        }
        public static int getNumber()
        {
            return number;
        }
        public static void Main(string[] args)
        {
            Calc c1 = new Calc(add);
            Calc c2 = new Calc(mul);

            c1(20);
            Console.WriteLine("After c1 delegate, number is: " + getNumber());

            c2(3);
            Console.WriteLine("After c2 delegate, number is: " + getNumber());
        }
    }
}