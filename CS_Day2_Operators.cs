using System;

class Solution
{
    static void solve(double meal_cost, int tip_percent, int tax_percent)
    {
        double tip; double tax; double totalCost;
        double Meal_cost = meal_cost;
        int Tip_percent = tip_percent;
        int Tax_percent = tax_percent;
        tip = Meal_cost * Tip_percent / 100;
        tax = Meal_cost * Tax_percent / 100;
        totalCost = Meal_cost + tip + tax;

        Console.WriteLine(Convert.ToInt32(totalCost));
    }

    static void Main(string[] args)
    {
        double meal_cost = Convert.ToDouble(Console.ReadLine());

        int tip_percent = Convert.ToInt32(Console.ReadLine());

        int tax_percent = Convert.ToInt32(Console.ReadLine());

        solve(meal_cost, tip_percent, tax_percent);
    }
}
