using System;

namespace UserDefineExceptions
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string msg) : base (msg) 
        {
        }
        class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    Console.Write("Enter age: ");
                    int age = Convert.ToInt16(Console.ReadLine());

                    if (age < 18)
                    {
                        throw new InvalidAgeException("Sorry, Age must be greater than 18");
                    }
                }
                catch (InvalidAgeException e)
                {
                    Console.WriteLine (e);
                }
                Console.WriteLine("You are eligible for vote");
            }
        }
    }
}