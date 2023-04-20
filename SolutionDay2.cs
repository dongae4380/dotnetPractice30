/*
Day 2
Operations
*/

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'solve' function below.
     *
     * The function accepts following parameters:
     *  1. DOUBLE meal_cost
     *  2. INTEGER tip_percent
     *  3. INTEGER tax_percent
     */

    public static void solve(double meal_cost, int tip_percent, int tax_percent)
    {
        double total_cost;
        double tip_cost = meal_cost * tip_percent / 100.0;
        double tax_cost = meal_cost * tax_percent / 100.0;
        total_cost = (int)Math.Round(meal_cost + tip_cost + tax_cost);
        Console.WriteLine(total_cost);
    }

}

class SolutionDay2
{
    public static void Main(string[] args)
    {
        // Read inputs
        string[] inputs = new string[3];
        for (int idx = 0; idx < 3; idx++)
        {
            inputs[idx] = Console.ReadLine() ?? "";
        }

        if (inputs.Any(string.IsNullOrEmpty))
        {
            Console.WriteLine("Please provide inputs correctly.");
            return;
        }

        double meal_cost = Convert.ToDouble(inputs[0].Trim());
        int tip_percent = Convert.ToInt32(inputs[1].Trim());
        int tax_percent = Convert.ToInt32(inputs[2].Trim());

        Result.solve(meal_cost, tip_percent, tax_percent);
    }
}

