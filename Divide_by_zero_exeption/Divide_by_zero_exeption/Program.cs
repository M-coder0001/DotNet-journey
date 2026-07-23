using System;

namespace Divide_by_zero_exception
{
    class program
    {
        static void Main(String[]args)
        {
            Console.WriteLine("enter the value of a and b");
            int a = Convert.ToInt16(Console.ReadLine());
            int b = Convert.ToInt16(Console.ReadLine());
            int result = 0;
            try
            {
                result = a / b;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("number cannot be divide by zero!!!!!");
            }
            finally
            {
                Console.WriteLine("result:{0}", result);
            }
        }

    }
}