using System;

public class ParameterizedConstructor
{
    public string productName;
    public double productPrice;
    public int productQuantity;

    public ParameterizedConstructor(string name, double price, int quantity)
    {
        productName = name;
        productPrice = price;
        productQuantity = quantity;
    }
    public void DisplayDetails()
    {
        double totalPrice = productPrice * productQuantity;
        Console.WriteLine("Product Name: " + productName);
        Console.WriteLine("Price: " + productPrice);
        Console.WriteLine("Product Quentity: " + productQuantity);
        Console.WriteLine("Total Bill: " + totalPrice);
        Console.WriteLine("=====================================");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("========== PRODUCT DETAILS ==========");
        Console.WriteLine("=====================================");
        ParameterizedConstructor p1 = new ParameterizedConstructor("Laptop", 50000, 2);
        ParameterizedConstructor p2 = new ParameterizedConstructor("Mobile", 20000, 3);
        p1.DisplayDetails();
        p2.DisplayDetails();
    }
}