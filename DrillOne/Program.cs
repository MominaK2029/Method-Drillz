using System;

namespace MyApplication
{
  class Program
  {
    static void PrintWelcome(string fname)
    {
      Console.WriteLine("Welcome, " + fname + " to C# Class.");
    }

    static void Main(string[] args)
    {
      PrintWelcome("Tracy");
      PrintWelcome("Heather");
      PrintWelcome("Liam");
    }
  }
}