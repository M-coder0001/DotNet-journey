using System;

namespace OperatorOverloading2
{
   class Class1
    {
        public int number1, number2;
        public Class1 (int num1,int num2)
        {
            number1 = num1;
            number2 = num2;
        }
        public static Class1 operator -(Class1 c1)
        {
            c1.number1 = -c1.number1; //15 = -15
            c1.number2 = -c1.number2; //-25 =+ 15
            return c1;
        }
        public void Print()
        {
            Console.WriteLine("Number1 =" + number1); 
            Console.WriteLine("Number2 =" + number2);
        }
        static void Main(string[] args)
        {
            Class1 calc = new Class1(15, -25);
            Console.WriteLine("before operator overloading");
            calc.Print();

            calc = -calc;
            Console.WriteLine("After operator overloading");
            calc.Print();
        }
    }
}

