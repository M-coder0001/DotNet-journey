using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            object str = "Hello";
            int value = (int)str;
            Console.WriteLine("Value = " + value);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid Number format");
        }
        catch (InvalidCastException)
        {
            Console.WriteLine("Error: Invalid type casting");
        }
        finally
        {
            Console.WriteLine("Example of multiple catch blocks");
        }
    }
}