using System;

namespace P2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your namae: ");
            string name = Console.ReadLine();

            Console.Write("Enter your RollNo: ");
            int rollNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ebter your branch name: ");
            string branch = Console.ReadLine();

            Console.Write("Enter your semester: ");
            int semester = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("==========================================");

            Console.WriteLine("Student name: " + name);
            Console.WriteLine("Roll No: " + rollNo);
            Console.WriteLine("Branch: " + branch);
            Console.WriteLine("Semester: " + semester);
            Console.ReadKey();

        }
    }
}