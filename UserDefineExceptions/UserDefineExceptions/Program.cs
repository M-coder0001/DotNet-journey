using System;

namespace UserDefineExceptions
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string msg) : base(msg)
        {
        }
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
                    throw new InvalidAgeException(
                        "Sorry, Age must be 18 or above"
                    );
                }

                Console.WriteLine("You are eligible for vote");
            }
            catch (InvalidAgeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}