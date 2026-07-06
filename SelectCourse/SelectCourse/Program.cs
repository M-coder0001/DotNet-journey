using System;

namespace SelectCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type one of the following to see details: CSharp, Java, DBMS, OperatingSystem");
            Console.Write("\nEnter Course Name: ");
            string course = Console.ReadLine().ToLower();
            Console.WriteLine();
            switch (course)
            {
                case "csharp":
                    Console.WriteLine("Course: C# Programming");
                    Console.WriteLine("Details: You will learn Object-Oriented Programming (OOP) and Windows applications.");
                    break;
                case "java":
                    Console.WriteLine("Course: Java Programming");
                    Console.WriteLine("Details: You will learn platform-independent coding and Android app basics.");
                    break;
                case "dbms":
                    Console.WriteLine("Course: Database Management System");
                    Console.WriteLine("Details: You will learn SQL queries, tables, and how to store data efficiently.");
                    break;
                case "operatingsystem":
                    Console.WriteLine("Course: Operating System");
                    Console.WriteLine("Details: You will learn process scheduling, memory management, and file systems.");
                    break;
                default:
                    Console.WriteLine("Error: Course not found in the current semester syllabus.");
                    break;
            }
        }
    }
}