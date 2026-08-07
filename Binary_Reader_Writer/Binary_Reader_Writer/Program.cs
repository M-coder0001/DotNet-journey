using System;
using System.IO;

namespace Binary_Reader_Writer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open("D:\\BinaryFile.dat", FileMode.Create)))
            {
                writer.Write(42);
                writer.Write(3.14);
                writer.Write("Hello, World!");
            }
            using (BinaryReader reader = new BinaryReader(File.Open("D:\\BinaryFile.dat", FileMode.Open)))
            {
                int intValue = reader.ReadInt32();
                double doubleValue = reader.ReadDouble();
                string stringValue = reader.ReadString();
                Console.WriteLine($"Read values: {intValue}, {doubleValue}, {stringValue}");
            }
        }
    }
}