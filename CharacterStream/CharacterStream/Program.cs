using System;
using System.IO;

class CharacterStream
{
    public static void Main(string[] args)
    {
        FileStream f = new FileStream("D:\\test.txt", FileMode.Create);
        StreamWriter writer = new StreamWriter(f);
        writer.WriteLine("Hello, World!");
        writer.Close();
        f.Close();

        Console.WriteLine("File created successfully.");

        FileStream f1 = new FileStream("D:\\test.txt", FileMode.OpenOrCreate);
        StreamReader reader = new StreamReader(f1);
        string line = " ";
        while ((line = reader.ReadLine()) != null){
            Console.WriteLine(line);
        }
        reader.Close();
        f1.Close();
    }
}