using System;

public class Person
{
    public string name = "Mayank";
}
public class Student : Person
{
    public int RollNo = 502;
}
public class ResearchStudent : Student
{
    public string ResearchTopic = "Quantum Computing";
}
public interface SportsActivity
{
    void PlayMatch();
}
public interface CulturalActivity
{
    void ParticipateInEvent();
}
public class AllRounderResearchStudent : ResearchStudent, SportsActivity, CulturalActivity
{   public void PlayMatch()
    {
        Console.WriteLine("Sports: Represented the iniversity in the Inter-College Chess Match");
    }
    public void ParticipateInEvent()
    {
        Console.WriteLine("Cultural: Participated as a lead guitarist in the Annual Fest");
    }
}
class Multilevel_Multiple3
{
    public static void Main(string[] args)
    {
        Console.WriteLine("===Multilevel Interface===");
        AllRounderResearchStudent student = new AllRounderResearchStudent();
        Console.WriteLine("Student Name: " + student.name);
        Console.WriteLine("Rol Np: " + student.RollNo);
        Console.WriteLine("Research Topic: " + student.ResearchTopic);

        Console.WriteLine();

        Console.WriteLine("===Multiple Interface (Class + Interface)===");
        student.PlayMatch();
        student.ParticipateInEvent();
    }
}