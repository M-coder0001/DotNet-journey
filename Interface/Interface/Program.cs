using System;

public interface IOrderService
{
    void ProcessOrder();
}
public class StandardDelivery : IOrderService
{
    public void ProcessOrder() 
    {
        Console.Write("Enter item name for standard Delivery: ");
        string item = Console.ReadLine();
        Console.WriteLine("Order placed! For the Product " + item + " and standard delivery will arrive TODAY!");
    }
}
public class ExpressDelivery : IOrderService
{
    public void ProcessOrder()
    {
        Console.Write("Enter item name for Express Delivery: ");
        string item = Console.ReadLine();
        Console.WriteLine("Order placed! For the Product " + item + " and Express delivery will arrive TODAY!");
    }
}
class Program
{
    static void Main(string[] args)
    {
        StandardDelivery service = new StandardDelivery();
        service.ProcessOrder();

        ExpressDelivery service1 = new ExpressDelivery();
        service1.ProcessOrder();
        
        Console.ReadKey();
    }
}