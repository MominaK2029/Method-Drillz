using System;

    class Program
    {
        static double FahrenheitToCelsius(double f)
        {
          return (f - 32.0) * 5/9;
    }

    static void Main(string[] args)
    {
      double c = FahrenheitToCelsius(54);
      Console.WriteLine(c);
    }
  }