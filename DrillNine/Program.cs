using System;

class Program
{
    static double CalculatePrice(double cost, double tax = 0.07)
    {
        tax = tax + 1;
        return cost * tax;
    }
    static void Main()
    {
        double price = CalculatePrice(10);
        Console.WriteLine("with tax will be " + price);
    }
}
