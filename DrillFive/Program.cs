using System;

class Program
{
    static void Main()
    {
        static void CountDown(int startnum)
        {
            while (startnum > 0)
            {
                Console.WriteLine(startnum);
                startnum -= 1;
                Console.WriteLine("Bye!");
            }
        }
        CountDown(10);
    }
}