using System;

class Program
{
    static bool IsValidPassword(string password)
    {
        Console.WriteLine("Enter an 8 character password:");
        password = Console.ReadLine() ?? string.Empty;

        if (password.Length < 8)
        {
            return false;
        }
        if (password.Contains (" "))
        {
            return false;
        }
            Console.WriteLine("Does this password have 8 chracters?" + (password.Length > 8));
            Console.WriteLine("Does this password have 8 chracters?" + password.Contains (" "));
            return true;

    }

       static void Main(string[] args);
//     {
//         bool result = IsValidPassword();
//         Console.WriteLine("Is this password valid?" + result);
//     }
}