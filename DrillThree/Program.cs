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
        //return n%2 == 0
    }
    static void Main()
        {
            int x = 41;
            bool result = isEven(x);
            Console.WriteLine(result);
        }

}
