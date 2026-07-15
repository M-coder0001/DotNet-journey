using System;

public abstract class Vehicle
{
    public abstract void StartEngine();
}
public class Car : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Car engine started");
    }
}
public class Motorcycle : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Motorcycle engine started..");
    }
}
public class TestAbstract
{
    public static void Main()
    {
        Vehicle myVehicle;

        myVehicle = new Car();
        myVehicle.StartEngine();

        myVehicle = new Motorcycle();
        myVehicle.StartEngine();
    }
}
