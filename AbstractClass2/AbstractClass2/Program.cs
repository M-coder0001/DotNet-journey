using System;

namespace AbstractClass1
{
    public abstract class Shape
    {
        public abstract void area();
    }
    public class Circle : Shape
    {
        int r;
        public override void area()
        {
            Console.Write("Enter  Radius of circle: ");
            r = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Area of circle is: " + (3.14 * r * r));
        }
    }
    public class Square : Shape
    {
        int s;
        public override void area()
        {
            Console.Write("Enter value of side: ");
            s = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Area of Square is: " + (s * s));   
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape sh;
            sh = new Circle();
            sh.area();
            sh = new Square();
            sh.area();
            Console.ReadKey();
        }
    }
}