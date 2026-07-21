using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter your exam percentage (0 to 100): ");
            int per = Convert.ToInt32(Console.ReadLine());

            if (per < 0 || per > 100)
            {
                throw new ArgumentException("Percentage must be between 0 to 100");
            }
            Console.WriteLine("Result saved successfully! " + per + "%");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid number format. Please enter numbers only.");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Input validation check completed.");
        }
    }
}