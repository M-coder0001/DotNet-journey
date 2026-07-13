using System;

public class Cal
{
    public static int add(int a, int b)
    {
        return a + b;
    }
    public static float add(float a, float b)
    {
        return a + b;
    }
}
public class FunctionOverloading
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Cal.add(12, 23));
        Console.WriteLine(Cal.add(12.4f, 21.3f));
    }
}