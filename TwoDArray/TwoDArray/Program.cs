using System;

namespace TwoDArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] marks =
            {
                {75, 48, 86}, 
                {65, 45, 24}, 
                {24, 54, 90}
            };
            Console.WriteLine("Marks of students in different subjects:");
            for(int i = 0; i <3; i++)
            {
                Console.Write("Student:- " + (i + 1) + " Marks:- ");
                for(int j = 0; j<3; j++)
                {
                    Console.Write(marks[i, j] + " ");
                }
                Console.WriteLine();
            } 
        }
    }
}

