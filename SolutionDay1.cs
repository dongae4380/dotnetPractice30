/*
Day 1
Data Types
*/

using System;
using System.Collections.Generic;
using System.IO;

class SolutionDay1 {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        // Read and save an integer, double, and String to your variables.
        int input_i = Convert.ToInt32(Console.ReadLine().Trim());
        double input_d = Convert.ToDouble(Console.ReadLine().Trim());
        string input_s = Console.ReadLine().Trim();
        
        Console.WriteLine(i + input_i);
        Console.WriteLine((d + input_d).ToString("0.0"));
        Console.WriteLine(s + input_s);

    }
}