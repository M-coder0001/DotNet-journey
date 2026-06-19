using System;

namespace P3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number1 and Number2:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition is" + add(number1, number2));

            Console.WriteLine("Subtraction is " + sub(number1, number2));

            Console.WriteLine("Multiplication is: " + mul(number1, number2));

            Console.WriteLine("Division is: " + div(number1, number2));
        }
        static int add(int number1, int number2)
        {
            return number1 + number2;
        }
        static int sub(int number1, int number2)
        {
            return number1 - number2;
        }
        static int mul(int number1, int number2)
        {
            return number1 * number2;
        }
        static int div(int number1, int number2)
        {
            return number1 / number2;
        }
        
    }
}