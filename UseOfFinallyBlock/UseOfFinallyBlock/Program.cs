using System;

namespace UseOfFinallyBlock
{
    class program
    {
        static void Main(string[] args)
        {
            String[] subject = { "java", "python", ".net", "c++" };
            Console.WriteLine("enter array index which you want to access");
            int index = Convert.ToInt16(Console.ReadLine());
            try
            {
                Console.WriteLine("subject = " + subject[index]);
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("invalid array index");
            }
            finally
            {
                index = 0;
                Console.WriteLine("finally block executed");
                Console.WriteLine("index reset to {0}", index);
            }
        }
    }
}