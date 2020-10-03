/*
 * C# Program to Find the Frequency of the Word ʺtheʺ in a given Sentence
 */
using System;
class program
{
    public static void Main()
    {
        string s1;
        Console.WriteLine("Enter the String : ");
        s1 = Console.ReadLine();
        // the program doesn't consider as part of the counting when 
        // 'the' is spelled with uppercase (The)
        // I'm still checking on this one
        Console.WriteLine(counting.CountStringOccurrences(s1, "the")); 
        Console.ReadLine();
    }
}
public static class counting
{
    public static int CountStringOccurrences(string text, string pattern)
    {
        int count = 0;
        int i = 0;
        while ((i = text.IndexOf(pattern, i)) != -1)
        {
            i += pattern.Length;
            count++;
        }
        return count;
    }
}