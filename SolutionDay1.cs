/*
Day 1
Data Types
*/

using System;
using System.Collections.Generic;
using System.IO;

class SolutionDay1 {
    static void Main(String[] args) {
        const int i = 4;
        const double d = 4.0;
        const string s = "HackerRank ";

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

        // Save an integer, double, and String to your variables.
        int input_i = Convert.ToInt32(inputs[0].Trim());
        double input_d = Convert.ToDouble(inputs[1].Trim());
        string input_s = inputs[2].Trim();
        
        Console.WriteLine(i + input_i);
        Console.WriteLine((d + input_d).ToString("0.0"));
        Console.WriteLine(s + input_s);

    }
}