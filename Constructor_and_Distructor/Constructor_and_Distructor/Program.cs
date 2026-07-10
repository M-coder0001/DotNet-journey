using System;
public class Constructor_and_Destructor
{
        public Constructor_and_Destructor()
        {
            Console.WriteLine("Resource Initialized (Constructor Invoked)");
        }
        ~Constructor_and_Destructor()
        {
            Console.WriteLine("Resource Cleaned Up (Destructor Invoked)");
            Console.ReadKey();
        }
}
class TestResources
{   
    public static void Main(string[] args)
    {
        Constructor_and_Destructor rm = new Constructor_and_Destructor();
    }
}
