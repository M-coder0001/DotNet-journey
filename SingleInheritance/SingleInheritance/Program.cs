using System;

public class Employee
{
    public string Name = "Mayank";
    public float baseSalary = 50000;
}

public class Manager : Employee
{
    public string department = "IT Department";
}

class SingleInheritance
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Single Inheritance (Manager) ===");
        Manager m1 = new Manager();
        Console.WriteLine("Name: " + m1.Name);
        Console.WriteLine("Salary: " + m1.baseSalary);
        Console.WriteLine("Department: " + m1.department);
    }
}
