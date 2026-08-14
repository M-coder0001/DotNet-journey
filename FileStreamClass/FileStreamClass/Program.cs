using System;
using System.IO;

namespace FileStreamClass
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i;

            //Write into File
            FileStream f = new FileStream("D:\\b.txt", FileMode.OpenOrCreate);

            for (i = 65; i <= 90; i++)
            {
                f.WriteByte((byte)i);
            }
            f.Close();

            Console.WriteLine("File Created");

            //read from file

            FileStream f1 = new FileStream("D:\\b.txt", FileMode.Open);

            i = 0;
            while ((i = f1.ReadByte()) != -1)
            {
                Console.WriteLine((char)i);
            }
            f.Close();
        }
    }
}