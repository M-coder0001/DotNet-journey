using System;

public class Employee
{
    public string employee = "Mayank";
}
public class Manager : Employee
{
    public string department = "Sales";
}
public class RegionalHead : Manager
{
    public string region = "North America";
}
public interface ITechnialSkills
{
    void ShowTechSkills();
}
public class Techlead : Manager, ITechnialSkills
{
    public string codingLanguage = "C#";

    public void ShowTechSkills()
    {
        Console.WriteLine("Technical Skill: Expert in: " + codingLanguage);
    }
}
class Multilevel_Multiple
{
    public static void Main(string[] args)
    {
        Console.WriteLine("===Multilevel Interface===");
        RegionalHead rh = new RegionalHead();
        Console.WriteLine("Name: " + rh.employee);
        Console.WriteLine("Department: " + rh.department);
        Console.WriteLine("Regino: " + rh.region);

        Console.WriteLine();
        
        Console.WriteLine("===Multiple Interface (Class + Interface)===");
        Techlead t1 = new Techlead();
        Console.WriteLine("Name: " + t1.employee);
        Console.WriteLine("Department: " + t1.department);

        t1.ShowTechSkills();
    }
}