using System;

class Solution
{
    static void Main(String[] args)
    {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        int j = Convert.ToInt32(Console.ReadLine());
        double e = Convert.ToDouble(Console.ReadLine());
        string t = Console.ReadLine();

        Console.WriteLine(i + j);
        Console.WriteLine((e + d).ToString("F1"));
        Console.WriteLine(s + t);
    }
}