using System;
using System.Collections.Generic;

class Solution
{
    static void Main(String[] args)
    {
        Dictionary<string, int> phoneB = new Dictionary<string, int>();

        int n = Convert.ToInt32(Console.ReadLine());

        for (var i = 0; i < n; i++)
        {
            var entry = Console.ReadLine().Split(' ');
            var name = entry[0];
            var phone = int.Parse(entry[1]);
            phoneB.Add(name, phone);
        }
        for (var i = 0; i < n; i++)
        {
            string str = Console.ReadLine();
            if (phoneB.ContainsKey(str))
            {
                var phone = phoneB[str];
                Console.WriteLine($"{str}={phone}");
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}

