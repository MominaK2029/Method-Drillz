using System;

class Program
{
    static int CountVowel(string word)
    {
        int count = 0;
        foreach (char c in word)

            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
            {
                count++;
            }
        return count;

    }
    static void Main()
    {
        Console.WriteLine($"There are {CountVowel("Hello")} vowels in this word");
    }
}
