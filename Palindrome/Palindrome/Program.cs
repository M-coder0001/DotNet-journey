using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
           string str ,rev = "";
            Console.Write("Enter a string: ");
            str = Console.ReadLine();
            int i, l;
            l = str.Length - 1;

            for (i = l; i >= 0; i--)
            {
                rev = rev + str[i];
            }
            if (rev == str)
            {
                Console.WriteLine("The string is a palindrome.");
            }
            else
            {
                Console.WriteLine("The string isn't a palindrome.");
            }
        }

    }
}
