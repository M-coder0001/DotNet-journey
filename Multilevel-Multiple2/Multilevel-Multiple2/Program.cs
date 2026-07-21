using System;

public class Vehicle
{
    public string brand = "BMW";
}
public class Car : Vehicle
{
    public int seatingCapacity = 4;
}
public class SportCar : Car
{
    public int maxspeed = 320;
}
public interface MaintenanceService
{
    void performanceTuneUp();
}
public interface InsurenceService
{
    void calculatePremium();
}
public class FullServicedSportCar : SportCar, MaintenanceService, InsurenceService
{
    public void performanceTuneUp()
    {
        Console.WriteLine("Maintenance: High-Performance egine tune-up completed");
    }
    public void calculatePremium()
    {
        Console.WriteLine("Insurence: premium calculated based on sports tier category");
    }
}
class Multilevel_Multiple2
{
    public static void Main(string[] args)
    {
        FullServicedSportCar myCaar = new FullServicedSportCar();

        Console.WriteLine("=== Multilevel Interface (Vehicle spect) ===");
        Console.WriteLine("Brand: " + myCaar.brand);
        Console.WriteLine("Seats: " + myCaar.seatingCapacity);
        Console.WriteLine("Max Speed: " + myCaar.maxspeed);

        Console.WriteLine();

        Console.WriteLine("===Multiple Interface (Serviced used)===");
        myCaar.performanceTuneUp();
        myCaar.calculatePremium();
    }
}