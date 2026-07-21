using System;

namespace OperatorOverloading
{
    class Program
    {
        public int rno;
        public string name;

        public Program(int n, string nm)
        {
            rno = n;
            name = nm;
        }
        public static Program operator +(Program p1)
        {
            p1.rno = p1.rno + 1;
            p1.name = "Hello " + p1.name;
            return p1;
        }
        public void Print()
        {
            Console.WriteLine("Roll No: " + rno);
            Console.WriteLine("Name: " + name);
        }
        static void Main(string[] args)
        {
            Program calc = new Program(10, "Atmiya");
            Console.WriteLine("Before overloading");
            calc.Print();

            calc = +calc;
            Console.WriteLine("After loading");
            calc.Print();

        }
    }
}