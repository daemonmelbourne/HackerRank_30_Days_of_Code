using System;

class Solution
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

        Array.Reverse(arr);

        foreach (int i in arr)
        {
            Console.Write($"{i} ");
        }
    }
}
