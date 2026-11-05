using System;

class Program
{
    static void Main()
    {
        int total = CalcSum([178, 254, 3678]);
        Console.WriteLine($"The total is {total}");
    }
    static int CalcSum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
// main

