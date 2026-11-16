using System;

class Program
{
    //Multiply 1
    static int Multiply(int a , int b)
    {
        return (a * b);
    } 
    //Multiply 2
    static double Multiply(double a , double b)
    {
        return (a * b);
    } 
    //Multiply 3
    static int Multiply(int a , int b , int c)
    {
        return (a * b * c);
    } 
    static void Main()
    {
        Console.WriteLine(Multiply(2, 4));
        Console.WriteLine(Multiply(1.2, 3.4));
        Console.WriteLine(Multiply(1, 2, 3));
    }
}
