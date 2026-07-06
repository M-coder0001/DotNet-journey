using System;

namespace OneDArray
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] arr = {100, 200, 300, 400, 500 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Recent Trandaction is {i}: {arr[i]}");
            }
        }
    }
}