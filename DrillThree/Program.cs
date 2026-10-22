using System;

class Program
{
    static bool isEven (int x)
    {
        int remain = x % 2;
        if (remain == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void Main()
        {
            int x = 40;
            if (isEven(x))
                Console.WriteLine("True.");
            else
                Console.WriteLine("False.");
        }

}
