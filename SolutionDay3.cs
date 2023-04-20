/*
Day 3
Intro to Conditional Statements
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



class SolutionDay3
{
    public static void Main(string[] args)
    {
        // Read & check input
        string? input = Console.ReadLine();
        if (input == null)
        {
            Console.WriteLine("Please provide input.");
            return;
        }

        int N = Convert.ToInt32(input.Trim());
        const string WEIRD = "Weird";
        const string NOT_WEIRD = "Not Weird";
        
        if (N % 2 == 1)
        {
            Console.WriteLine(WEIRD);
            return;
        }
        
        IEnumerable<int> weird_range = Enumerable.Range(6, 15);
        if (weird_range.Contains(N))
        {
            Console.WriteLine(WEIRD);
        }
        else
        {
            Console.WriteLine(NOT_WEIRD);
        }
    }
}
