using System;

namespace P4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            object obj = num; // Boxing
            int unboxedNum = (int)obj; // Unboxing

            Console.WriteLine("Num Type: " + num.GetType());
            Console.WriteLine("Obj Type: " + obj.GetType());
            Console.WriteLine("unboxedNum Type: " + unboxedNum.GetType());

            Console.ReadKey();
        }
    }
}