using System;

namespace AnonymosFun_WithoutSeparateMethod
{
    class Program
    {
        delegate int Square(int num);
        static void Main(string[] args)
        {
            Square GetSquare = x => x;
            int j = GetSquare(5);
            Console.WriteLine("The square is: {0}", j);
        }
    }
}