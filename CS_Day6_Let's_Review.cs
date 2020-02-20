using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        var N = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            var str = Console.ReadLine();

            for (int j = 0; j < str.Length; j++)
            {
                if (j % 2 == 0) Console.Write(str[j]);
            }
            Console.Write(" ");
            for (var j = 0; j < str.Length; j++)
            {
                if (j % 2 != 0) Console.Write(str[j]);
            }
            Console.Write(Environment.NewLine);
        }
    }
}

