using System;

class Program
{
    string word = ("Hello");
    int count = 0;
    static int CountVowel(string word)
    {
        foreach (char c in word)
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
            {
                count ++;
            }
        return count;
    }
    static void Main()
    {
        Console.Write(CountVowel);
    }
}
