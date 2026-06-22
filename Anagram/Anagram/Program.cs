using System;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first word: ");
            string s1 = Console.ReadLine().Replace(" "," ").ToLower();


            Console.Write("Enter the second word: ");
            string s2 = Console.ReadLine().Replace(" ", " ").ToLower();

            char[] char1 = s1.ToCharArray();
            char[] char2 = s2.ToCharArray();

            Array.Sort(char1);
            Array.Sort(char2);

            string str1 = new string(char1);
            string str2 = new string(char2);

            if (str1 == str2)
            {
                Console.WriteLine("The words are anagrams.");
            }
            else
            {
                Console.WriteLine("The words are not anagrams.");
            }
            Console.ReadKey();
        }
    }
}