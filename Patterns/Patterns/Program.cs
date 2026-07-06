using System;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            char ch ='A';

            for (i = 1; i <= 5; i++)
            {
                for(j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.WriteLine("====================================");

            for (i = 1; i <= 4; i++)
            {
                ch = 'A';
                for (j = 3; j >= i ; j--)
                {
                    Console.Write(" ");
                }
                for(k= 1; k <= i; k++)
                {
                    Console.Write(ch + " ");
                    ch++;
                }
        Console.WriteLine();
            }
            Console.WriteLine("====================================");

            for(i = 1; i <= 5; i++)
            {
                for (j = 5; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
