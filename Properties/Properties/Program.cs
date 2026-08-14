using System;


public class Employee
{
    private string name;

    public string Name
    {
        get
        {
            return name;
        }
        set 
        { 
            name = value; 
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Employee employee = new Employee();
        employee.Name = "mynk";
        Console.WriteLine($"Employee Name: {employee.Name}");
    }
}