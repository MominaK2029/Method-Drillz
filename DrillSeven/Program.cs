using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        int[] nums = ([178, 254, 3678, 2]);

        int max = FindMax(nums);
        Console.WriteLine($"The max is {max}");
    }
    static int FindMax(int[] nums)
    {
        int maximum = 0;
        for (int i=0; i<nums.Length; i++)
        {
            if (nums[i] > maximum)
            {
                maximum = nums[i];
            }
        }
        return maximum;
    }
}
